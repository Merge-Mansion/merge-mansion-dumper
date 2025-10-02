using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.Fallbacks;
using System;

namespace GameLogic.Player.Rewards
{
    [MetaSerializableDerived(47)]
    public class RewardOnFire : PlayerReward
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaDuration Duration { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private FallbackPlayerRewardId FallbackRewardId { get; set; }
        public int Amount { get; }
        public override bool ShouldShowInfoButton { get; }
    }
}