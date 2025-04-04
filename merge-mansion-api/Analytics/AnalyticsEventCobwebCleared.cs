using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using System.ComponentModel;
using Metaplay.Core.Model;
using System;

namespace Analytics
{
    [AnalyticsEvent(180, "Cobweb cleared", 1, null, false, true, false)]
    public class AnalyticsEventCobwebCleared : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Board event id")]
        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [Description("Board id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("board_id")]
        public string BoardId { get; set; }

        [Description("Cleared item name")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("row_index")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Slot's row index (aka y axis)")]
        public int RowIndex { get; set; }

        [JsonProperty("column_index")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Slot's column index (aka x axis)")]
        public int ColumnIndex { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventCobwebCleared()
        {
        }

        public AnalyticsEventCobwebCleared(string eventId, string boardId, string itemName, int rowIndex, int columnIndex)
        {
        }
    }
}