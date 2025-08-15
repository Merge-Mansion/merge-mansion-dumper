using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.InAppPurchase.Steam
{
    [MetaSerializableDerived(5)]
    public class SteamInitiationParams : ServerDrivenInAppPurchaseInitiationParams
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool UseWebUserSession;
    }
}