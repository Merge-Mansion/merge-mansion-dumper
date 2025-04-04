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

        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Event item name")]
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Event item collected from board")]
        [JsonProperty("board_id")]
        public string BoardId { get; set; }

        [JsonProperty("event_id")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Event id")]
        public string EventId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Event item rarity")]
        [JsonProperty("rarity")]
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