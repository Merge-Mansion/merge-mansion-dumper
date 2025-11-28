using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Rewards
{
    [MetaSerializableDerived(48)]
    public class RewardStartingValues : PlayerReward
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public RewardContainerId VisualRewardContainerId { get; set; }
        public override bool ShouldShowInfoButton { get; }
    }
}