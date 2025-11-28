using System.Collections.Generic;
using Metaplay.Core;
using Metaplay.Core.Model;
using System;
using GameLogic.Config;

namespace GameLogic.Player.Items.Sink
{
    [MetaSerializableDerived(2)]
    public class SingleTargetSinkStateFactory : ISinkStateFactory
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public Dictionary<int, int> Scores { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int ScoreTarget { get; set; }

        private SingleTargetSinkStateFactory()
        {
        }

        public SingleTargetSinkStateFactory(Dictionary<int, int> scores, int scoreTarget, int reward)
        {
        }

        public SingleTargetSinkStateFactory(List<ValueTuple<int, int>> scores, int scoreTarget, int reward)
        {
        }

        [MetaMember(3, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef RewardDef { get; set; }
    }
}