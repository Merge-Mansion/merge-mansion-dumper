using System;
using System.IO;

namespace merge_mansion_dumper.Dumper
{
    static class DumpHelper
    {
        private const string MergeChainFileName = "chain_item_odds.json";
        private const string AreaFileName = "areas.json";
        private const string EventFileName = "events.json";
        //private const string DialogDirName = "dialogs";

        public static void DumpAll(string? outputDir)
        {
            DumpMergeChains(outputDir);
            DumpAreas(outputDir);
            DumpEvents(outputDir);
            //DumpDialogs(outputDir);
        }

        public static void DumpMergeChains(string? outputDir)
        {
            ClearLine();
            Console.WriteLine("Dump merge chains... ");

            try
            {
                CreateMergeChainDump().WriteJson(GetOutputFolder(MergeChainFileName, outputDir), ClientGlobal.SharedGameConfig);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Skipped ({e.Message})");
            }
        }

        public static void DumpAreas(string? outputDir)
        {
            ClearLine();
            Console.WriteLine("Dump areas... ");

            try
            {
                CreateAreaDumper().WriteJson(GetOutputFolder(AreaFileName, outputDir), ClientGlobal.SharedGameConfig);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Skipped ({e.Message})");
            }
        }

        public static void DumpEvents(string? outputDir)
        {
            ClearLine();
            Console.WriteLine("Dump events... ");

            try
            {
                CreateEventDumper().WriteJson(GetOutputFolder(EventFileName, outputDir), ClientGlobal.SharedGameConfig);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Skipped ({e.Message})");
            }
        }

        //public static void DumpDialogs(string? outputDir)
        //{
        //    ClearLine();
        //    Console.WriteLine("Dump dialogs... ");

        //    try
        //    {
        //        CreateDialogDumper().ExportImages(GetOutputFolder(DialogDirName, outputDir), ClientGlobal.SharedGameConfig);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Skipped ({e.Message})");
        //    }
        //}

        //public static IList<MergeChainDefinition> GetMergeChainData()
        //{
        //    return CreateMergeChainDump().Dump(ClientGlobal.SharedGameConfig);
        //}

        //public static IList<AreaInfo> GetAreaData()
        //{
        //    return CreateAreaDumper().Dump(ClientGlobal.SharedGameConfig);
        //}

        //public static IDictionary<string, object> GetEventData()
        //{
        //    return CreateEventDumper().Dump(ClientGlobal.SharedGameConfig);
        //}

        private static MergeChainDumper CreateMergeChainDump()
        {
            return new MergeChainDumper(true);
        }

        private static AreaDumper CreateAreaDumper()
        {
            return new AreaDumper();
        }

        private static EventDumper CreateEventDumper()
        {
            return new EventDumper();
        }

        //private static DialogDumper CreateDialogDumper()
        //{
        //    return new DialogDumper();
        //}

        private static string GetOutputFolder(string fileName, string? subDir)
        {
            string outputDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dump");
            if (subDir is not null)
                outputDir = Path.Combine(outputDir, subDir);

            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);

            return Path.Combine(outputDir, fileName);
        }

        private static void ClearLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
