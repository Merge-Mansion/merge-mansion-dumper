using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Metaplay.Core.InAppPurchase;
using System;
using Metaplay.Core.Math;

namespace Metaplay.Core.Player
{
    [AnalyticsEvent(1024, "In App Purchase Refunded", 1, "A previously completed purchase was refunded, charged back, or similar. Refunds can be invoked by customer support, by the user, or by the purchasing platform due to various reasons (e.g. suspected fraud). The event may contain more information about the reason.", true, true, false)]
    [AnalyticsEventKeywords(new string[] { "InAppPurchase" })]
    public class PlayerEventInAppPurchaseRefunded : PlayerEventBase
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public InAppProductId ProductId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public InAppPurchasePlatform Platform { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string TransactionId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string OrderId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public string PlatformProductId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public F64 ReferencePrice { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public string GameProductAnalyticsId { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public InAppPurchasePaymentType? PaymentType { get; set; }

        [FirebaseAnalyticsIgnore]
        [MetaMember(9, (MetaMemberFlags)0)]
        public PurchaseAnalyticsContext PurchaseContext { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public InAppPurchaseRefundReason RefundReason { get; set; }

        [FirebaseAnalyticsIgnore]
        [MetaMember(11, (MetaMemberFlags)0)]
        public InAppPurchaseRefundResult RefundResult { get; set; }
        public override string EventDescription { get; }
    }
}