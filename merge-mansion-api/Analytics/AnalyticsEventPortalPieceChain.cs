using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using GameLogic.Player.Items;
using System;

namespace Analytics
{
    [AnalyticsEvent(181, "Portal piece chain", 1, null, false, true, false)]
    public class AnalyticsEventPortalPieceChain : AnalyticsServersideEventBase
    {
        [MetaMember(4, (MetaMemberFlags)0)]
        [JsonProperty("action")]
        [Description("Action that happened")]
        public PortalPieceChainAnalyticsType Action;
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("event_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Board event id")]
        public string EventId { get; set; }

        [Description("Board id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("board_id")]
        public string BoardId { get; set; }

        [Description("Related item name")]
        [JsonProperty("item_name")]
        [MetaMember(3, (MetaMemberFlags)0)]
        public string ItemName { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventPortalPieceChain()
        {
        }

        public AnalyticsEventPortalPieceChain(string eventId, string boardId, string itemName, PortalPieceChainAnalyticsType action)
        {
        }
    }
}