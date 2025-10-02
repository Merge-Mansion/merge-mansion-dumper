using Metaplay.Core.Model;
using Metaplay.Core;
using Metaplay.Core.Forms;
using System.Runtime.Serialization;
using System;

namespace GameLogic.Player.Rewards
{
    [MetaSerializableDerived(26)]
    [MetaFormDeprecated]
    public class RewardCooldownRemover : PlayerReward
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaDuration Duration { get; set; }

        public RewardCooldownRemover()
        {
        }

        public RewardCooldownRemover(MetaDuration duration)
        {
        }

        [IgnoreDataMember]
        public override bool ShouldShowInfoButton { get; }
    }
}