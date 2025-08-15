using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Metaplay.Core.InAppPurchase;
using System;
using Metaplay.Core.Math;

namespace Metaplay.Core.Player
{
    [AnalyticsEvent(1025, "In App Purchase Restored", 1, "An purchase of the same product (which isn't a consumable) was made by the same purchasing platform account but on a different player account. It has been granted to this player account without making a new purchase.", true, true, false)]
    [AnalyticsEventKeywords(new string[] { "InAppPurchase" })]
    public class PlayerEventInAppPurchaseRestored : PlayerEventBase
    {
        [MetaMember(2, (MetaMemberFlags)0)]
        public InAppProductId ProductId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public InAppPurchasePlatform Platform { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string TransactionId { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public string OrderId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public string PlatformProductId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public F64 ReferencePrice { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public string GameProductAnalyticsId { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public InAppPurchasePaymentType? PaymentType { get; set; }

        [FirebaseAnalyticsIgnore]
        [MetaMember(8, (MetaMemberFlags)0)]
        public PurchaseAnalyticsContext PurchaseContext { get; set; }
        public override string EventDescription { get; }
    }
}