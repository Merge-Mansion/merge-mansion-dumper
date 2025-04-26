using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using System.ComponentModel;
using Newtonsoft.Json;
using System;
using GameLogic;

namespace Analytics
{
    [AnalyticsEventKeywords(new string[] { "buysell", "event" })]
    [MetaBlockedMembers(new int[] { 3 })]
    [AnalyticsEvent(174, "Rentable inventory purchased", 1, null, true, true, false)]
    public class AnalyticsEventRentableInventoryBatchPurchased : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Batch cost")]
        [JsonProperty("batch_cost")]
        public long Cost { get; set; }

        [Description("Batch currency")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("batch_currency")]
        public Currencies Currency { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventRentableInventoryBatchPurchased()
        {
        }

        public AnalyticsEventRentableInventoryBatchPurchased(long cost, Currencies currency)
        {
        }
    }
}