using Metaplay.Core.Model;
using System;
using System.Collections.Generic;

namespace Metaplay.Core.Player
{
    [MetaSerializableDerived(1)]
    public class SteamPlatformData : IPlatformSpecificData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaTime LastUpdated { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string State { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string Country { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string Currency { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public SteamPurchasingStatus PurchasingStatus { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        [Transient]
        public Dictionary<int, int> PricePointToHundredthsOfCurrency { get; set; }
    }
}