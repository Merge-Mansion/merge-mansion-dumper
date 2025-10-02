using Metaplay.Core.Model;
using Newtonsoft.Json;
using System;
using Metaplay.Core;
using GameLogic.Player.Items;
using System.ComponentModel;
using GameLogic.Player;

namespace Analytics
{
    [MetaSerializable]
    public class AnalyticsBoardStateMetaData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("charges", NullValueHandling = (NullValueHandling)1)]
        public int? Charges { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [JsonProperty("duration_left", NullValueHandling = (NullValueHandling)1)]
        public MetaDuration? TimeContainerRemaining { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [JsonProperty("is_active", NullValueHandling = (NullValueHandling)1)]
        public bool? IsActive { get; set; }

        public AnalyticsBoardStateMetaData()
        {
        }

        public AnalyticsBoardStateMetaData(MergeItem item)
        {
        }

        [JsonProperty("item_level")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Item level")]
        public int ItemLevel { get; set; }

        [JsonProperty("item_mergechain_total_length")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("Merge chain total length of the item")]
        public int ItemMergeChainTotalLength { get; set; }

        [JsonProperty("item_mergechain_unlocked_length")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Merge chain unlocked length of the item")]
        public int ItemMergeChainUnlockedLength { get; set; }

        public AnalyticsBoardStateMetaData(MergeItem item, PlayerModel player)
        {
        }
    }
}