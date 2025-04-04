using Metaplay.Core.Model;
using System;
using Metaplay.Core;

namespace Code.GameLogic.Ads
{
    [MetaSerializable]
    public class AdsWatchLimiter
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private int AdPlacementLimitPerDay { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private MetaDuration CooldownBetweenAds { get; set; }

        public AdsWatchLimiter()
        {
        }

        public AdsWatchLimiter(int adLimit, MetaDuration cooldownBetweenAds)
        {
        }
    }
}