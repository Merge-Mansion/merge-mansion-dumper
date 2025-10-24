using Metaplay.Core.Model;
using System.Collections.Generic;
using Merge;
using Metaplay.Core;
using Metaplay.Core.Forms;
using System.Runtime.Serialization;
using System;

namespace GameLogic.Player.Rewards
{
    [MetaSerializableDerived(24)]
    [MetaFormDeprecated]
    public class RewardSkipTime : PlayerReward
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public List<MergeBoardId> MergeBoardIds { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaDuration DurationToSkip { get; set; }

        public RewardSkipTime()
        {
        }

        public RewardSkipTime(List<MergeBoardId> mergeBoardIds, MetaDuration durationToSkip)
        {
        }

        [IgnoreDataMember]
        public override bool ShouldShowInfoButton { get; }

        private static string BOOSTER_NAME;
    }
}