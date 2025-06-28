using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommandLine;
using CommandLine.Text;
using Game.Logic;
using GameLogic.Config;
using merge_mansion_dumper.Dumper;
using Metaplay.Core;
using Metaplay.Core.Config;
using Metaplay.Core.Localization;
using Metaplay.Core.Player;
using Metaplay.Core.Serialization;
using Metaplay.Unity;
using Metaplay.Unity.ConnectionStates;
using UnityEngine;

namespace merge_mansion_dumper
{
    class Options
    {
        [Option('m', "mode", Required = true, HelpText = "Set the mode to dump data with\n  1: all\n  2: merge chains\n  3: areas\n  4: events\n  5: dialogs")]
        public int Mode { get; set; }

        [Option('c', "config", Required = false, HelpText = "Sets the path to the config archive to use. This will not download any other data archives or localizations!")]
        public string ConfigArchivePath { get; set; }

        [Option('p', "patch", Required = false, HelpText = "Sets the path to the patch config archive to use. This will not download any other data archives or localizations!")]
        public string PatchConfigArchivePath { get; set; }

        [Option('l', "language", Required = false, HelpText = "Sets the path to the language mpc to use. This will not download any other data archives or localizations!")]
        public string LanguagePath { get; set; }
    }

    public enum Mode
    {
        All = 1,
        MergeChains,
        Areas,
        Events,
        //Dialogs
    }

    class Program
    {
        public static bool VersionBumped { get; private set; }

        static void Main(string[] args)
        {
            var parser = new Parser(parserSettings => parserSettings.AutoHelp = true);

            var parsedResult = parser.ParseArguments<Options>(args);

            parsedResult
                .WithNotParsed(errors => DisplayHelp(parsedResult, errors))
                .WithParsed(Execute);
        }

        private static void DisplayHelp<T>(ParserResult<T> result, IEnumerable<Error> errors)
        {
            var helpText = HelpText.AutoBuild(result, h =>
            {
                h.AdditionalNewLineAfterOption = false;
                return HelpText.DefaultParsingErrorsHandler(result, h);
            }, e => e);

            Console.WriteLine(helpText);
        }

        private static void Execute(Options o)
        {
            if (IsFixedSystem(o))
                DumpFixed(o);
            else
                DumpProduction(o);

            Console.WriteLine("Done.");
        }

        private static bool IsFixedSystem(Options o)
        {
            return !string.IsNullOrEmpty(o.ConfigArchivePath);
        }

        private static void DumpFixed(Options o)
        {
            MetaplayCore.Initialize();

            var specializationPatches = GameConfigSpecializationPatches.FromBytes(File.ReadAllBytes(o.PatchConfigArchivePath));
            var configPatches = specializationPatches.Patches.SelectMany(y => y.Value.Select(z => (y.Key, z.Key, GameConfigPatchEnvelope.Deserialize(z.Value)))).ToArray();

            // Setup system
            if (!SetupFixedSystem(o, configPatches, out IList<(PlayerExperimentId, ExperimentVariantId, PatchedConfigArchive)> patchedArchives))
                return;

            // Dump master data to files
            Dump(o);

            // Dump patched data to files
            var relevantPatchedArchives = patchedArchives.Where(x =>
                x.Item3.ContainsPatch("Areas")
                || x.Item3.ContainsPatch("HotspotDefinitions")
                || x.Item3.ContainsPatch("Items")).ToArray();

            Console.WriteLine();
            Console.WriteLine($"Process {relevantPatchedArchives.Length} patche(s).");

            foreach ((PlayerExperimentId experimentId, ExperimentVariantId variantId, PatchedConfigArchive patchedArchive) in relevantPatchedArchives)
            {
                // Set to null for early garbage collection
                ClientGlobal.SharedGameConfig = null;

                Console.WriteLine();
                ClientGlobal.SharedGameConfig = (SharedGameConfig)GameConfigFactory.Instance.ImportSharedGameConfig(patchedArchive);

                Console.WriteLine($"Dump experiment {experimentId} variant {variantId}:");

                Dump(o, $"{experimentId}_{variantId}");
            }
        }

        private static void DumpProduction(Options o)
        {
            if (!string.IsNullOrEmpty(o.LanguagePath))
                Console.WriteLine($"[!] Explicit language file {o.LanguagePath} will not be used for normal system setup. Set a config with -c instead to use it.");

            if (!string.IsNullOrEmpty(o.PatchConfigArchivePath))
                Console.WriteLine($"[!] Explicit patch config archive file {o.PatchConfigArchivePath} will not be used for normal system setup. Set a config with -c instead to use it.");

            // Setup system
            if (!SetupProductionSystem())
                return;

            // Dump data to files
            Dump(o);
        }

        private static bool SetupFixedSystem(Options o, (PlayerExperimentId, ExperimentVariantId, GameConfigPatchEnvelope)[] configPatches,
            out IList<(PlayerExperimentId, ExperimentVariantId, PatchedConfigArchive)> patchedArchives)
        {
            if (!string.IsNullOrEmpty(o.LanguagePath))
                MetaplaySDK.ActiveLanguage = LocalizationLanguage.ImportBinary(ContentHash.ParseString(Path.GetFileName(o.LanguagePath)), File.ReadAllBytes(o.LanguagePath));

            var archive = ConfigArchive.FromBytes(FileUtil.ReadAllBytes(o.ConfigArchivePath));

            patchedArchives = new List<(PlayerExperimentId, ExperimentVariantId, PatchedConfigArchive)>();
            foreach (var configPatch in configPatches)
            {
                var patchedArchive = new PatchedConfigArchive(archive, new[] { configPatch.Item3 });
                patchedArchives.Add((configPatch.Item1, configPatch.Item2, patchedArchive));
            }

            var gameConfig = (SharedGameConfig)GameConfigFactory.Instance.ImportSharedGameConfig(PatchedConfigArchive.WithNoPatches(archive));

            ClientGlobal.SharedGameConfig = gameConfig;

            return true;
        }

        private static bool SetupProductionSystem()
        {
            // HINT: Unused due to outdated communication protocols
            Console.WriteLine("Setup game session...");

            try
            {
            Initialize:
                MetaplayCore.Initialize();

                var client = new MetaplayClient();

                MetaplaySDK.Connection.Connect();

                while (ClientGlobal.SharedGameConfig == null)
                {
                    client.Update();

                    if (MetaplaySDK.Connection.State.Status != ConnectionStatus.Error)
                        continue;

                    if (MetaplaySDK.Connection.State is TerminalError.LogicVersionMismatch me)
                    {
                        Console.WriteLine($"[!] There is a new game version available: {me.ServerAcceptedVersions.MinVersion}");

                        VersionBumped = true;

                        GlobalOptions.MinVersion = me.ServerAcceptedVersions.MinVersion;
                        GlobalOptions.MaxVersion = me.ServerAcceptedVersions.MaxVersion;
                        Application.Version = $"{me.ServerAcceptedVersions.MinVersion}";

                        MetaplayCore.Reset();

                        goto Initialize;
                    }

                    if (MetaplaySDK.Connection.State is TerminalError.InMaintenance maintenance)
                    {
                        Console.WriteLine("Servers are in maintenance.");
                        return false;
                    }

                    Console.WriteLine($"Connection Error ({MetaplaySDK.Connection.State.GetType().Name})");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred setting up the session. Did the data models change?");
#if DEBUG
                Console.WriteLine($"Aborted ({e.Message})");
#endif

                return false;
            }

            return true;
        }

        private static void Dump(Options o, string? outputDir = null)
        {
            switch ((Mode)o.Mode)
            {
                case Mode.All:
                    DumpHelper.DumpAll(outputDir);
                    break;

                case Mode.MergeChains:
                    DumpHelper.DumpMergeChains(outputDir);
                    break;

                case Mode.Areas:
                    DumpHelper.DumpAreas(outputDir);
                    break;

                case Mode.Events:
                    DumpHelper.DumpEvents(outputDir);
                    break;

                    //case Mode.Dialogs:
                    //    DumpHelper.DumpDialogs();
                    //    break;
            }
        }
    }
}
