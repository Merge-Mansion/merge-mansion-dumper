using Metaplay.Core.Model;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Metaplay.Core.Config
{
    [MetaSerializable]
    public class GameConfigLibraryPatch<TKey, TInfo> : GameConfigEntryPatch<GameConfigLibrary<TKey, TInfo>, Dictionary<TKey, TInfo>>, IGameConfigLibraryPatch where TInfo : IGameConfigData<TKey>
    {
        [JsonProperty("replacedItems")]
        private Dictionary<TKey, TInfo> _replacedItems;
        [JsonProperty("appendedItems")]
        private Dictionary<TKey, TInfo> _appendedItems;
        [MetaMember(1, (MetaMemberFlags)0)]
        [MaxCollectionSize(2147483647)]
        [JsonIgnore]
        private List<GameConfigDataContent<TInfo>> _replacedItemsForSerialization { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MaxCollectionSize(2147483647)]
        [JsonIgnore]
        private List<GameConfigDataContent<TInfo>> _appendedItemsForSerialization { get; set; }

        private GameConfigLibraryPatch()
        {
        }

        public GameConfigLibraryPatch(IEnumerable<TInfo> replacedItems, IEnumerable<TInfo> appendedItems)
        {
        }

        internal override void PatchContentDangerouslyInPlace(Dictionary<TKey, TInfo> entryContent)
        {
            foreach (var replacedItem in _replacedItemsForSerialization)
            {
                if (entryContent.ContainsKey(replacedItem.ConfigData.ConfigKey))
                    entryContent[replacedItem.ConfigData.ConfigKey] = replacedItem.ConfigData;
            }

            foreach (var appendedItem in _appendedItemsForSerialization)
            {
                if (!entryContent.ContainsKey(appendedItem.ConfigData.ConfigKey))
                    entryContent[appendedItem.ConfigData.ConfigKey] = appendedItem.ConfigData;
            }
        }
    }
}