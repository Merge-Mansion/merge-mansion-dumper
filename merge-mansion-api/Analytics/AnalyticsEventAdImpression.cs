using Metaplay.Core.Analytics;
using System.ComponentModel;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System;

namespace Analytics
{
    [AnalyticsEvent(189, "Rewarded ad impression", 1, null, true, true, false)]
    public class AnalyticsEventAdImpression : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [Description("Ad platform")]
        [JsonProperty("ad_platform")]
        [MetaMember(1, (MetaMemberFlags)0)]
        public string AdPlatform { get; set; }

        [Description("Ad Network (previously Ad Source)")]
        [JsonProperty("ad_network")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public string AdSource { get; set; }

        [JsonProperty("ad_unit_name")]
        [Description("Ad unit name")]
        [MetaMember(3, (MetaMemberFlags)0)]
        public string AdUnitName { get; set; }

        [Description("Ad format")]
        [JsonProperty("ad_format")]
        [MetaMember(4, (MetaMemberFlags)0)]
        public string AdFormat { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Currency")]
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        [JsonProperty("value")]
        [Description("Value")]
        public double? Value { get; set; }

        [JsonProperty("auction_id")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Auction Id")]
        public string AuctionId { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("Ad placement")]
        [JsonProperty("ad_placement")]
        public string AdPlacement { get; set; }

        [Description("Item name")]
        [JsonProperty("item_name")]
        [MetaMember(9, (MetaMemberFlags)0)]
        public string ItemName { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventAdImpression()
        {
        }

        public AnalyticsEventAdImpression(string adPlatform, string adSource, string adUnitName, string adFormat, string currency, double? value, string auctionId, string adPlacement, string itemName)
        {
        }
    }
}