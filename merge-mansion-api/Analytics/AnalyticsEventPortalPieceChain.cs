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
        [JsonProperty("action")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Action that happened")]
        public PortalPieceChainAnalyticsType Action;
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("event_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Board event id")]
        public string EventId { get; set; }

        [JsonProperty("board_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Board id")]
        public string BoardId { get; set; }

        [JsonProperty("item_name")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Related item name")]
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