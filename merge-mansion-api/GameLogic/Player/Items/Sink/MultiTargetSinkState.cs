using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Config;

namespace GameLogic.Player.Items.Sink
{
    [MetaSerializableDerived(3)]
    public class MultiTargetSinkState : ISinkState
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private Dictionary<int, int> progress;
        [MetaMember(2, (MetaMemberFlags)0)]
        private Dictionary<int, int> targets;
        public MultiTargetSinkState()
        {
        }

        public MultiTargetSinkState(Dictionary<int, int> scoreTargets, ItemDefinition reward)
        {
        }

        [MetaMember(3, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        private ItemDef rewardItemDef;
    }
}