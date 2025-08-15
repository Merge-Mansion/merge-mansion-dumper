using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.InAppPurchase.Steam
{
    [MetaSerializableDerived(5)]
    public class SteamPlatformState : InAppPurchaseEventPlatformState
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string SteamUserId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public ulong SteamOrderId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public bool UseWebUserSession { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public string Currency { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public int PriceInCurrencyHundredths { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public ulong SteamTransId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public string SteamUrl { get; set; }
    }
}