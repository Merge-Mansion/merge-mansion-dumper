using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace Metaplay.Core.Config
{
    public class GameConfigPatch
    {
        [JsonProperty]
        private Dictionary<string, GameConfigEntryPatch> _entryPatches;
        public Type ConfigType { get; set; }
        public bool IsEmpty { get; }

        public GameConfigPatch(Type configType, Dictionary<string, GameConfigEntryPatch> entryPatches)
        {
        }
    }
}