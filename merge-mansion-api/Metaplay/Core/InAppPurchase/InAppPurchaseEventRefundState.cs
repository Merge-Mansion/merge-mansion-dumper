using Metaplay.Core.Model;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    public class InAppPurchaseEventRefundState
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public InAppPurchaseRefundReason Reason { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public InAppPurchaseRefundResult Result { get; set; }
    }
}