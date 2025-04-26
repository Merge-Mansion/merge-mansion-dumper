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
    [AnalyticsEvent(188, "Rewarded ad finished", 1, null, true, true, false)]
    public class AnalyticsEventAdFinished : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("ad_placement")]
        [Description("Ad placement")]
        public string AdPlacement { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("item_name")]
        [Description("Item name")]
        public string ItemName { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Auction Id")]
        [JsonProperty("auction_id")]
        public string AuctionId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        [JsonProperty("ad_unit")]
        [Description("Ad unit")]
        public string AdUnit { get; set; }

        [JsonProperty("ad_network")]
        [Description("Ad network")]
        [MetaMember(6, (MetaMemberFlags)0)]
        public string AdNetwork { get; set; }

        [Description("Instance name")]
        [JsonProperty("instance_name")]
        [MetaMember(7, (MetaMemberFlags)0)]
        public string InstanceName { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("Instance Id")]
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        [Description("Country")]
        [JsonProperty("country")]
        [MetaMember(9, (MetaMemberFlags)0)]
        public string Country { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        [Description("Revenue")]
        [JsonProperty("revenue")]
        public double Revenue { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        [JsonProperty("lifetime_revenue")]
        [Description("Lifetime revenue")]
        public double LifetimeRevenue { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        [Description("Precision")]
        [JsonProperty("precision")]
        public string Precision { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        [Description("Segment name")]
        [JsonProperty("segment_name")]
        public string SegmentName { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        [JsonProperty("encrypted_cpm")]
        [Description("Encrypted CPM")]
        public string EncryptedCpm { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventAdFinished()
        {
        }

        public AnalyticsEventAdFinished(string adPlacement, string itemName, string auctionId, string adUnit, string adNetwork, string instanceName, string instanceId, string country, double revenue, double lifetimeRevenue, string precision, string segmentName, string encryptedCpm)
        {
        }

        [MetaMember(15, (MetaMemberFlags)0)]
        [Description("Item Diamond value")]
        [JsonProperty("item_diamond_price")]
        public int ItemDiamondValue { get; set; }

        public AnalyticsEventAdFinished(string adPlacement, string itemName, string auctionId, string adUnit, string adNetwork, string instanceName, string instanceId, string country, double revenue, double lifetimeRevenue, string precision, string segmentName, string encryptedCpm, int itemDiamondValue)
        {
        }

        [JsonProperty("item_cost_value")]
        [Description("Item cost value")]
        [MetaMember(16, (MetaMemberFlags)0)]
        public int ItemCostValue { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        [JsonProperty("item_cost_value_type")]
        [Description("Item cost value type")]
        public Currencies ItemCostValueType { get; set; }

        [Description("Amount of time skipped for a producer")]
        [MetaMember(18, (MetaMemberFlags)0)]
        [JsonProperty("time_skipped_amount")]
        public string TimeSkippedAmount { get; set; }

        [Description("Diamond value of time skipped")]
        [JsonProperty("time_skipped_diamond_value")]
        [MetaMember(19, (MetaMemberFlags)0)]
        public int TimeSkippedDiamondValue { get; set; }

        [JsonProperty("time_remaining_amount")]
        [Description("Remaining time for producer")]
        [MetaMember(20, (MetaMemberFlags)0)]
        public string ProducerTimeRemaining { get; set; }

        public AnalyticsEventAdFinished(string adPlacement, string itemName, string auctionId, string adUnit, string adNetwork, string instanceName, string instanceId, string country, double revenue, double lifetimeRevenue, string precision, string segmentName, string encryptedCpm, int itemDiamondValue, int itemCostValue, Currencies itemCostValueType, AnalyticsContext analyticsContext)
        {
        }

        [MetaMember(21, (MetaMemberFlags)0)]
        [JsonProperty("required_items")]
        [Description("Required task items")]
        public string RequiredTaskItems { get; set; }

        [MetaMember(22, (MetaMemberFlags)0)]
        [Description("Required merge chain")]
        [JsonProperty("required_merge_chain")]
        public string RequiredMergeChains { get; set; }

        public AnalyticsEventAdFinished(string adPlacement, string itemName, string auctionId, string adUnit, string adNetwork, string instanceName, string instanceId, string country, double revenue, double lifetimeRevenue, string precision, string segmentName, string encryptedCpm, int itemDiamondValue, int itemCostValue, Currencies itemCostValueType, AnalyticsContext analyticsContext, string requiredTaskItems, string requiredMergeChains)
        {
        }
    }
}