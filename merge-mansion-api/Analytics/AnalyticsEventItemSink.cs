using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using System;
using Merge;
using System.Collections.Generic;
using GameLogic.Player;
using GameLogic.Player.Items;

namespace Analytics
{
    [AnalyticsEvent(173, "Item sink", 1, null, false, true, false)]
    public class AnalyticsEventItemSink : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("source_item")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Item that was sinked")]
        public string SourceItem { get; set; }

        [Description("Item that source_item was sinked into")]
        [JsonProperty("target_item")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public string TargetItem { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Id of the board where the item was sinked")]
        [JsonProperty("context")]
        public MergeBoardId MergeBoardId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [JsonProperty("sink_status_multi")]
        [Description("Sink status for FactoryType=Multi")]
        public Dictionary<string, ItemSinkProgressStatus> SinkStatusMulti { get; set; }

        [JsonProperty("sink_status_simple")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Sink status for FactoryType=Simple/Single")]
        public SimpleSinkProgressStatus SinkStatusSimple { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventItemSink()
        {
        }

        public AnalyticsEventItemSink(IPlayer player, MergeItem sourceItem, MergeItem targetItem, MergeBoardId mergeBoardId)
        {
        }

        private AnalyticsEventItemSink(string sourceItem, string targetItem, MergeBoardId mergeBoardId, Dictionary<string, ItemSinkProgressStatus> sinkStatusMulti, SimpleSinkProgressStatus sinkStatusSimple)
        {
        }

        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("Source item level")]
        [JsonProperty("source_item_level")]
        public int SourceItemLevel { get; set; }

        [Description("Merge chain total length of the source item")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [JsonProperty("source_item_mergechain_total_length")]
        public int SourceItemMergeChainTotalLength { get; set; }

        [Description("Merge chain unlocked length of the source item")]
        [JsonProperty("source_item_mergechain_unlocked_length")]
        [MetaMember(8, (MetaMemberFlags)0)]
        public int SourceItemMergeChainUnlockedLength { get; set; }

        [Description("Target item level")]
        [MetaMember(9, (MetaMemberFlags)0)]
        [JsonProperty("target_item_level")]
        public int TargetItemLevel { get; set; }

        [Description("Merge chain total length of the target item")]
        [MetaMember(10, (MetaMemberFlags)0)]
        [JsonProperty("target_item_mergechain_total_length")]
        public int TargetItemMergeChainTotalLength { get; set; }

        [JsonProperty("target_item_mergechain_unlocked_length")]
        [MetaMember(11, (MetaMemberFlags)0)]
        [Description("Merge chain unlocked length of the target item")]
        public int TargetItemMergeChainUnlockedLength { get; set; }

        private AnalyticsEventItemSink(string sourceItem, string targetItem, MergeBoardId mergeBoardId, Dictionary<string, ItemSinkProgressStatus> sinkStatusMulti, SimpleSinkProgressStatus sinkStatusSimple, int sourceItemLevel, int sourceItemMergeChainTotalLength, int sourceItemMergeChainUnlockedLength, int targetItemLevel, int targetItemMergeChainTotalLength, int targetItemMergeChainUnlockedLength)
        {
        }

        [MetaMember(12, (MetaMemberFlags)0)]
        [Description("Target Item SinkType")]
        [JsonProperty("target_item_sink_type")]
        public string TargetItemSinkType { get; set; }

        [Description("SinkTag of source item")]
        [MetaMember(13, (MetaMemberFlags)0)]
        [JsonProperty("source_item_tag")]
        public string SourceItemSinkTag { get; set; }

        [Description("How many points is the item worth")]
        [MetaMember(14, (MetaMemberFlags)0)]
        [JsonProperty("source_item_points")]
        public int SourceItemSinkPoints { get; set; }

        [Description("How many points in total are currently in target item")]
        [MetaMember(15, (MetaMemberFlags)0)]
        [JsonProperty("target_item_points")]
        public int TargetItemSinkPoints { get; set; }

        [Description("What phase is order item in")]
        [MetaMember(16, (MetaMemberFlags)0)]
        [JsonProperty("order_item_phase")]
        public string OrderItemPhase { get; set; }

        [Description("Current order index")]
        [JsonProperty("order_index")]
        [MetaMember(17, (MetaMemberFlags)0)]
        public int OrderIndex { get; set; }

        [JsonProperty("is_order_completed")]
        [MetaMember(18, (MetaMemberFlags)0)]
        [Description("Was order completed?")]
        public bool IsOrderCompleted { get; set; }

        private AnalyticsEventItemSink(string sourceItem, string targetItem, MergeBoardId mergeBoardId, Dictionary<string, ItemSinkProgressStatus> sinkStatusMulti, SimpleSinkProgressStatus sinkStatusSimple, int sourceItemLevel, int sourceItemMergeChainTotalLength, int sourceItemMergeChainUnlockedLength, int targetItemLevel, int targetItemMergeChainTotalLength, int targetItemMergeChainUnlockedLength, int targetItemSinkPoints)
        {
        }
    }
}