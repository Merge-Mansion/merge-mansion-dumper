using Metaplay.Core.Model;

namespace Metaplay.Core.InAppPurchase.Steam
{
    [MetaSerializable]
    public enum SteamClientHandlingStatus
    {
        Unknown = 0,
        Declined = 1,
        Approved = 2
    }
}