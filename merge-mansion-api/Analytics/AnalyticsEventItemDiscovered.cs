using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using System;

namespace Analytics
{
    [AnalyticsEvent(117, "Item discovered first time", 1, null, true, true, false)]
    [AnalyticsEventKeywords(new string[] { "item", "discovery" })]
    public class AnalyticsEventItemDiscovered : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [MetaOnMemberDeserializationFailure("FixItemType")]
        [JsonProperty("item_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Discovered item")]
        public string ItemName { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventItemDiscovered()
        {
        }

        public AnalyticsEventItemDiscovered(string itemName)
        {
        }

        [JsonProperty("item_level")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Discovered item level")]
        public int ItemLevel { get; set; }

        [JsonProperty("item_mergechain_total_length")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Merge chain total length of the discovered item")]
        public int ItemMergeChainTotalLength { get; set; }

        [JsonProperty("item_mergechain_unlocked_length")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Merge chain unlocked length of the discovered item")]
        public int ItemMergeChainUnlockedLength { get; set; }

        public AnalyticsEventItemDiscovered(string itemName, int itemLevel, int itemMergeChainTotalLength, int itemMergeChainUnlockedLength)
        {
        }
    }
}