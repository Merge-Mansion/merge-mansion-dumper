using System.Collections.Generic;
using Metaplay.Core;
using Metaplay.Core.Model;
using System;
using GameLogic.Config;

namespace GameLogic.Player.Items.Sink
{
    [MetaSerializableDerived(3)]
    public class MultiTargetSinkStateFactory : ISinkStateFactory
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public Dictionary<int, int> ScoreTargets { get; set; }

        private MultiTargetSinkStateFactory()
        {
        }

        public MultiTargetSinkStateFactory(Dictionary<int, int> scoreTargets, int reward)
        {
        }

        public MultiTargetSinkStateFactory(List<ValueTuple<int, int>> scores, int reward)
        {
        }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef RewardDef { get; set; }
    }
}