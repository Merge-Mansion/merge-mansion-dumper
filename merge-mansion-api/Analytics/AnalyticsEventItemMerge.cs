using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using System.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Analytics
{
    [AnalyticsEvent(103, "Item merged", 1, null, true, true, false)]
    [AnalyticsEventKeywords(new string[] { "item", "merge" })]
    public class AnalyticsEventItemMerge : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("item_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Item that has been merge")]
        public string MergedItem { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventItemMerge()
        {
        }

        public AnalyticsEventItemMerge(string itemType)
        {
        }

        [JsonProperty("item_level")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Merged item level")]
        public int MergedItemLevel { get; set; }

        [JsonProperty("item_mergechain_total_length")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Merge chain total length of the merged item")]
        public int MergedItemMergeChainTotalLength { get; set; }

        [JsonProperty("item_mergechain_unlocked_length")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Merge chain unlocked length of the merged item")]
        public int MergedItemMergeChainUnlockedLength { get; set; }

        public AnalyticsEventItemMerge(string itemType, int itemLevel, int itemMergeChainTotalLength, int itemMergeChainUnlockedLength)
        {
        }

        [JsonProperty("spawner")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Is this spawner?")]
        public bool IsSpawner { get; set; }
        public override IEnumerable<string> KeywordsForEventInstance { get; }

        public AnalyticsEventItemMerge(string itemType, int itemLevel, int itemMergeChainTotalLength, int itemMergeChainUnlockedLength, bool isSpawner)
        {
        }
    }
}