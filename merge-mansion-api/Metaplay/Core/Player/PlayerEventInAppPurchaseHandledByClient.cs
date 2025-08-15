using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Metaplay.Core.InAppPurchase;
using System;
using Metaplay.Core.Math;

namespace Metaplay.Core.Player
{
    [AnalyticsEvent(1022, "In App Purchase Handled by Client", 1, "The client has informed the server that the user has handled the server-initiated purchase.", true, true, false)]
    [AnalyticsEventKeywords(new string[] { "InAppPurchase" })]
    public class PlayerEventInAppPurchaseHandledByClient : PlayerEventBase
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

        [FirebaseAnalyticsIgnore]
        [MetaMember(10, (MetaMemberFlags)0)]
        public ServerDrivenInAppPurchaseClientHandlingResult ClientHandlingResult { get; set; }
        public override string EventDescription { get; }
    }
}