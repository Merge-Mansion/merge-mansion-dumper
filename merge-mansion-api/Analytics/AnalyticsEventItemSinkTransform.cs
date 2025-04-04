using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using Merge;
using System;
using GameLogic.Player.Items;

namespace Analytics
{
    [AnalyticsEvent(201, "Sink item transformed by completion", 1, null, false, true, false)]
    public class AnalyticsEventItemSinkTransform : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [Description("Id of the board where the item was sinked")]
        [JsonProperty("context")]
        [MetaMember(1, (MetaMemberFlags)0)]
        public MergeBoardId MergeBoardId { get; set; }

        [Description("Source item SinkType")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("source_item_sink_type")]
        public string SourceItemSinkType { get; set; }

        [Description("Name of the item sink transformed into")]
        [JsonProperty("item_name")]
        [MetaMember(3, (MetaMemberFlags)0)]
        public string NewItemName { get; set; }

        [Description("Original sink item name")]
        [JsonProperty("origin_item_name")]
        [MetaMember(4, (MetaMemberFlags)0)]
        public string OriginItemName { get; set; }

        [JsonProperty("total_points")]
        [Description("If sink item required points, then how many points were in the original sink item")]
        [MetaMember(5, (MetaMemberFlags)0)]
        public int TotalPoints { get; set; }

        [Description("True if original item was Order item")]
        [JsonProperty("was_order_item")]
        [MetaMember(6, (MetaMemberFlags)0)]
        public bool WasOrderItem { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventItemSinkTransform()
        {
        }

        public AnalyticsEventItemSinkTransform(MergeItem originItem, MergeItem newItem, MergeBoardId mergeBoardId)
        {
        }
    }
}