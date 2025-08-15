using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Metaplay.Core.InAppPurchase;
using System;
using Metaplay.Core.Math;

namespace Metaplay.Core.Player
{
    [AnalyticsEvent(1020, "In App Purchase Initiation Started by Server", 1, "The server has started the initiation of a purchase, following a request from the client.", true, true, false)]
    [AnalyticsEventKeywords(new string[] { "InAppPurchase" })]
    public class PlayerEventInAppPurchaseInitiationStarted : PlayerEventBase
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public InAppProductId ProductId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public InAppPurchasePlatform Platform { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string TransactionId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string PlatformProductId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public F64 ReferencePrice { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public string GameProductAnalyticsId { get; set; }

        [FirebaseAnalyticsIgnore]
        [MetaMember(7, (MetaMemberFlags)0)]
        public PurchaseAnalyticsContext PurchaseContext { get; set; }
        public override string EventDescription { get; }
    }
}