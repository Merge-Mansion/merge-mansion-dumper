using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using System.ComponentModel;
using Newtonsoft.Json;
using Merge;
using System;
using Metaplay.Core;
using System.Collections.Generic;

namespace Analytics
{
    [AnalyticsEventKeywords(new string[] { "item", "booster" })]
    [AnalyticsEvent(136, "Booster/Bonus item used", 1, null, true, true, false)]
    public class AnalyticEventBoosterUsed : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("board_id")]
        [Description("Board where the Booster was used")]
        public MergeBoardId BoardId { get; set; }

        [JsonProperty("duration_in_minutes")]
        [Description("Boosters duration")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public double Duration { get; set; }

        [MetaOnMemberDeserializationFailure("FixItemType")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [JsonProperty("target_item")]
        [Description("Boosters target item")]
        public string TargetItem { get; set; }

        [Description("Boosters target item")]
        [MetaOnMemberDeserializationFailure("FixItemType")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [JsonProperty("source_item")]
        public string SourceItem { get; set; }

        [JsonProperty("from_inventory")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("True if item was used from inventory")]
        public bool FromInventory { get; set; }
        public override string EventDescription { get; }

        public AnalyticEventBoosterUsed()
        {
        }

        public AnalyticEventBoosterUsed(string sourceItem, MergeBoardId boardId, MetaDuration duration, bool fromInventory)
        {
        }

        public AnalyticEventBoosterUsed(string sourceItem, MergeBoardId boardId, string targetItem, bool fromInventory)
        {
        }

        public AnalyticEventBoosterUsed(string sourceItem, MergeBoardId boardId, string targetItem, MetaDuration duration)
        {
        }

        [Description("Target item level")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [JsonProperty("target_item_level")]
        public int TargetItemLevel { get; set; }

        [JsonProperty("target_item_mergechain_total_length")]
        [Description("Merge chain total length of the target item")]
        [MetaMember(7, (MetaMemberFlags)0)]
        public int TargetItemMergeChainTotalLength { get; set; }

        [Description("Merge chain unlocked length of the target item")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [JsonProperty("target_item_mergechain_unlocked_length")]
        public int TargetItemMergeChainUnlockedLength { get; set; }

        [JsonProperty("source_item_level")]
        [Description("Source item level")]
        [MetaMember(9, (MetaMemberFlags)0)]
        public int SourceItemLevel { get; set; }

        [Description("Merge chain total length of the source item")]
        [MetaMember(10, (MetaMemberFlags)0)]
        [JsonProperty("source_item_mergechain_total_length")]
        public int SourceItemMergeChainTotalLength { get; set; }

        [JsonProperty("source_item_mergechain_unlocked_length")]
        [MetaMember(11, (MetaMemberFlags)0)]
        [Description("Merge chain unlocked length of the source item")]
        public int SourceItemMergeChainUnlockedLength { get; set; }

        public AnalyticEventBoosterUsed(string sourceItem, MergeBoardId boardId, MetaDuration duration, bool fromInventory, int sourceItemLevel, int sourceItemMergeChainTotalLength, int sourceItemMergeChainUnlockedLength)
        {
        }

        public AnalyticEventBoosterUsed(string sourceItem, MergeBoardId boardId, string targetItem, bool fromInventory, int sourceItemLevel, int sourceItemMergeChainTotalLength, int sourceItemMergeChainUnlockedLength)
        {
        }

        public AnalyticEventBoosterUsed(string sourceItem, MergeBoardId boardId, string targetItem, bool fromInventory, int sourceItemLevel, int sourceItemMergeChainTotalLength, int sourceItemMergeChainUnlockedLength, int targetItemLevel, int targetItemMergeChainTotalLength, int targetItemMergeChainUnlockedLength)
        {
        }

        public AnalyticEventBoosterUsed(string sourceItem, MergeBoardId boardId, string targetItem, MetaDuration duration, int sourceItemLevel, int sourceItemMergeChainTotalLength, int sourceItemMergeChainUnlockedLength, int targetItemLevel, int targetItemMergeChainTotalLength, int targetItemMergeChainUnlockedLength)
        {
        }

        public override IEnumerable<string> KeywordsForEventInstance { get; }
    }
}