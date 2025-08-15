using Metaplay.Core.Model;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    public enum InAppPurchaseStatus
    {
        PendingValidation = 0,
        ReceiptAlreadyUsed = 3,
        _Reserved_4 = 4,
        _Reserved_5 = 5,
        _Reserved_6 = 6,
        Refunded = 7,
        MissingContent = 8,
        Successful = 1,
        Failed = 2,
        UserDeclined = 9,
        Abandoned = 10
    }
}