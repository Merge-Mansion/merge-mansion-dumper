using Metaplay.Core.Model;
using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using System.ComponentModel;
using Metaplay.Core.Offers;
using System;
using Metaplay.Core;
using Metaplay.Core.Math;
using Metaplay.Core.Player;

namespace Analytics
{
    [MetaBlockedMembers(new int[] { 6, 14, 16 })]
    [AnalyticsEvent(137, "Meta Offer Impression", 1, null, false, true, false)]
    public class AnalyticEventOfferImpression : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [Description("Offer Id")]
        [JsonProperty("item_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaOfferId OfferId { get; set; }

        [Description("Offer Group Id")]
        [JsonProperty("group_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaOfferGroupId OfferGroupId { get; set; }

        [Description("Platform Id")]
        [JsonProperty("iap_platform_id")]
        [MetaMember(3, (MetaMemberFlags)0)]
        public string PlatformId { get; set; }

        [JsonProperty("placement")]
        [Description("Placement Id")]
        [MetaMember(4, (MetaMemberFlags)0)]
        public OfferPlacementId PlacementId { get; set; }

        [Description("Shown automatically")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [JsonProperty("automatic_show")]
        public bool AutomaticallyShown { get; set; }

        [Description("Offer activations")]
        [JsonProperty("activations")]
        [MetaMember(7, (MetaMemberFlags)0)]
        public int Activations { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        [JsonProperty("impression_id")]
        [Description("Impression Id")]
        public string ImpressionId { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        [Description("Offer purchases")]
        [JsonProperty("purchases")]
        public int Purchases { get; set; }
        public override string EventDescription { get; }

        public AnalyticEventOfferImpression()
        {
        }

        public AnalyticEventOfferImpression(MetaOfferId offerId, MetaOfferGroupId offerGroupId, string platformId, OfferPlacementId placementId, bool automaticallyShown, int activations, int purchases, string impressionId)
        {
        }

        [Description("Offer trigger")]
        [JsonProperty("trigger_type")]
        [MetaMember(10, (MetaMemberFlags)0)]
        public string PopupTrigger { get; set; }

        public AnalyticEventOfferImpression(MetaOfferId offerId, MetaOfferGroupId offerGroupId, string platformId, OfferPlacementId placementId, bool automaticallyShown, int activations, int purchases, string impressionId, string popupTrigger)
        {
        }

        [Description("The offer start date and hour")]
        [JsonProperty("start_date_hour")]
        [MetaMember(11, (MetaMemberFlags)0)]
        public MetaTime? StartDate { get; set; }

        [Description("The offer end date and hour")]
        [JsonProperty("end_date_hour")]
        [MetaMember(12, (MetaMemberFlags)0)]
        public MetaTime? EndDate { get; set; }

        [JsonProperty("duration")]
        [Description("The offer duration in hours")]
        [MetaMember(13, (MetaMemberFlags)0)]
        public long? Duration { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        [Description("The offer price in USD")]
        [JsonProperty("reference_price")]
        public F64 ReferencePrice { get; set; }

        [Description("Array of all rewards & their amount in the offer - only contant items")]
        [JsonProperty("offer_items")]
        [MetaMember(15, (MetaMemberFlags)0)]
        public string OfferItems { get; set; }

        [JsonProperty("segment")]
        [Description("Players segment for the offer")]
        [MetaMember(19, (MetaMemberFlags)0)]
        public PlayerSegmentId Segment { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        [Description("Offer global counter")]
        [JsonProperty("offer_counter")]
        public int OfferGlobalCounter { get; set; }

        public AnalyticEventOfferImpression(MetaOfferId offerId, MetaOfferGroupId offerGroupId, string platformId, OfferPlacementId placementId, bool automaticallyShown, int activations, int purchases, string impressionId, string popupTrigger, MetaTime? startDate, MetaTime? endDate, long? duration, long referencePrice, string offerItems, string segment, int offerGlobalCounter)
        {
        }

        public AnalyticEventOfferImpression(MetaOfferId offerId, MetaOfferGroupId offerGroupId, string platformId, OfferPlacementId placementId, bool automaticallyShown, int activations, int purchases, string impressionId, string popupTrigger, MetaTime? startDate, MetaTime? endDate, long? duration, F64 referencePrice, string offerItems, PlayerSegmentId segment, int offerGlobalCounter)
        {
        }

        [MetaMember(20, (MetaMemberFlags)0)]
        [JsonProperty("step", NullValueHandling = (NullValueHandling)1)]
        [Description("Tiered offer step for the offer")]
        public int? Step { get; set; }

        public AnalyticEventOfferImpression(MetaOfferId offerId, MetaOfferGroupId offerGroupId, string platformId, OfferPlacementId placementId, bool automaticallyShown, int activations, int purchases, string impressionId, string popupTrigger, MetaTime? startDate, MetaTime? endDate, long? duration, F64 referencePrice, string offerItems, PlayerSegmentId segment, int offerGlobalCounter, int? step)
        {
        }
    }
}