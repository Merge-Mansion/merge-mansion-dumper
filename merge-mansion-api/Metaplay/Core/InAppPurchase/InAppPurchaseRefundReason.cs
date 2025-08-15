using Metaplay.Core.Model;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    public class InAppPurchaseRefundReason : DynamicEnum<InAppPurchaseRefundReason>
    {
        public static InAppPurchaseRefundReason Unknown;
        public static InAppPurchaseRefundReason AdminApi;
        public static InAppPurchaseRefundReason StoreGeneral;
        public static InAppPurchaseRefundReason StoreRequestedByUser;
        public static InAppPurchaseRefundReason StoreChargedBack;
        public static InAppPurchaseRefundReason StoreSuspectedFraud;
        public static InAppPurchaseRefundReason StoreFriendlyFraud;

        protected InAppPurchaseRefundReason(int id, string name, bool isValid) : base(id, name, isValid)
        {
        }
    }
}