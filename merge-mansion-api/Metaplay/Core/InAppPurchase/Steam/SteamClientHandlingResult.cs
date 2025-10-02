using Metaplay.Core.Model;

namespace Metaplay.Core.InAppPurchase.Steam
{
    [MetaSerializableDerived(5)]
    public class SteamClientHandlingResult : ServerDrivenInAppPurchaseClientHandlingResult
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public SteamClientHandlingStatus Status { get; set; }
    }
}