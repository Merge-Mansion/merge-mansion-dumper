using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using System;
using GameLogic;
using GameLogic.Player;

namespace Analytics
{
    [MetaBlockedMembers(new int[] { 3 })]
    [AnalyticsEvent(187, "Rewarded ad started", 1, null, true, true, false)]
    public class AnalyticsEventAdStarted : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("ad_placement")]
        [Description("Ad placement")]
        public string AdPlacement { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Item name")]
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [JsonProperty("auction_id")]
        [Description("Auction Id")]
        public string AuctionId { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventAdStarted()
        {
        }

        public AnalyticsEventAdStarted(string adPlacement, string itemName, string auctionId)
        {
        }

        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Item Diamond value")]
        [JsonProperty("item_diamond_price")]
        public int ItemDiamondValue { get; set; }

        public AnalyticsEventAdStarted(string adPlacement, string itemName, string auctionId, int itemDiamondValue)
        {
        }

        [Description("Item cost value")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [JsonProperty("item_cost_value")]
        public int ItemCostValue { get; set; }

        [JsonProperty("item_cost_value_type")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Item cost value type")]
        public Currencies ItemCostValueType { get; set; }

        [JsonProperty("advertiser_id")]
        [Description("Advertiser Id")]
        [MetaMember(8, (MetaMemberFlags)0)]
        public string AdvertiserId { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        [JsonProperty("ad_network")]
        [Description("Ad Network")]
        public string NetworkId { get; set; }

        [Description("Amount of time skipped for a producer")]
        [MetaMember(10, (MetaMemberFlags)0)]
        [JsonProperty("time_skipped_amount")]
        public string TimeSkippedAmount { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        [Description("Diamond value of time skipped")]
        [JsonProperty("time_skipped_diamond_value")]
        public int TimeSkippedDiamondValue { get; set; }

        [Description("Remaining time for producer")]
        [JsonProperty("time_remaining_amount")]
        [MetaMember(12, (MetaMemberFlags)0)]
        public string ProducerTimeRemaining { get; set; }

        public AnalyticsEventAdStarted(string adPlacement, string itemName, string auctionId, int itemDiamondValue, int itemCostValue, Currencies itemCostValueType, string advertiserId, string networkId, AnalyticsContext analyticsContext)
        {
        }

        [Description("Required task items")]
        [JsonProperty("required_items")]
        [MetaMember(13, (MetaMemberFlags)0)]
        public string RequiredTaskItems { get; set; }

        [JsonProperty("required_merge_chain")]
        [MetaMember(14, (MetaMemberFlags)0)]
        [Description("Required merge chain")]
        public string RequiredMergeChains { get; set; }

        public AnalyticsEventAdStarted(string adPlacement, string itemName, string auctionId, int itemDiamondValue, int itemCostValue, Currencies itemCostValueType, string advertiserId, string networkId, AnalyticsContext analyticsContext, string requiredTaskItems, string requiredMergeChain)
        {
        }
    }
}