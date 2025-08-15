using Metaplay.Core.Model;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    public class InAppPurchasePendingRefundHandling
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public InAppPurchaseRefundReason Reason { get; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public InAppPurchaseRefundData RefundDataMaybe { get; }
    }
}