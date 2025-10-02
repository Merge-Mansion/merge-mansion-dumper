using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Rewards
{
    [MetaSerializableDerived(37)]
    public class RewardContainer : PlayerReward
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public RewardContainerId RewardContainerId { get; set; }

        public RewardContainer()
        {
        }

        public RewardContainer(RewardContainerId rewardContainerId)
        {
        }

        public override bool ShouldShowInfoButton { get; }
    }
}