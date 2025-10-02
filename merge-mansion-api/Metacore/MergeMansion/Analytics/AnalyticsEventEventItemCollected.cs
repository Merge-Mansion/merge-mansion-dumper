using Metaplay.Core.Analytics;
using Analytics;
using Metaplay.Core.Model;
using System.ComponentModel;
using Newtonsoft.Json;
using System;

namespace Metacore.MergeMansion.Analytics
{
    [AnalyticsEvent(213, "Event item collected", 1, null, false, true, false)]
    public class AnalyticsEventEventItemCollected : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("item_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Event item name")]
        public string ItemName { get; set; }

        [JsonProperty("board_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Event item collected from board")]
        public string BoardId { get; set; }

        [JsonProperty("event_id")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Event id")]
        public string EventId { get; set; }

        [JsonProperty("rarity")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Event item rarity")]
        public string Rarity { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventEventItemCollected()
        {
        }

        public AnalyticsEventEventItemCollected(string itemName, string boardId, string eventId, string rarity)
        {
        }
    }
}