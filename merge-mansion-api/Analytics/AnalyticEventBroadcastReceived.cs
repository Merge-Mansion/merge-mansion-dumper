using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System;
using GameLogic.Mail;

namespace Analytics
{
    [AnalyticsEvent(134, "Broadcast received", 1, null, false, true, false)]
    [MetaBlockedMembers(new int[] { 1 })]
    public class AnalyticEventBroadcastReceived : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("broadcast_id")]
        public int BroadcastId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [JsonProperty("item_type")]
        public string BroadcastType { get; set; }
        public override string EventDescription { get; }

        public AnalyticEventBroadcastReceived()
        {
        }

        public AnalyticEventBroadcastReceived(IBroadcastMailMessage broadcastMailMessage)
        {
        }
    }
}