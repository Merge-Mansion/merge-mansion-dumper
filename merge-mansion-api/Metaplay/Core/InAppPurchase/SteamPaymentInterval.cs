using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    public struct SteamPaymentInterval
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int Frequency;
        [MetaMember(2, (MetaMemberFlags)0)]
        public SteamPeriod SteamPeriod;
    }
}