using Metaplay.Core.Model;
using Metaplay.Core;
using Metaplay.Core.Forms;
using System.Runtime.Serialization;
using System;

namespace GameLogic.Player.Rewards
{
    [MetaSerializableDerived(23)]
    [MetaFormDeprecated]
    public class RewardActivateInfiniteEnergy : PlayerReward
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaDuration Duration { get; set; }

        public RewardActivateInfiniteEnergy()
        {
        }

        public RewardActivateInfiniteEnergy(MetaDuration duration)
        {
        }

        [IgnoreDataMember]
        public override bool ShouldShowInfoButton { get; }

        private static string BOOSTER_NAME;
    }
}