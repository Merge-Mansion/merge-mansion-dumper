using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Config;

namespace GameLogic.Player.Items.Sink
{
    [MetaSerializableDerived(2)]
    public class SingleTargetSinkState : ISinkState
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private int progress;
        [MetaMember(2, (MetaMemberFlags)0)]
        private int target;
        [MetaMember(3, (MetaMemberFlags)0)]
        private Dictionary<int, int> takeInScores;
        public SingleTargetSinkState()
        {
        }

        public SingleTargetSinkState(Dictionary<int, int> takeIn, int scoreTarget, ItemDefinition reward)
        {
        }

        [MetaMember(4, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        private ItemDef rewardItemDef;
    }
}