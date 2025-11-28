using GameLogic.Player.Items;
using Metaplay.Core;
using Metaplay.Core.Model;
using System.Collections.Generic;
using System;
using GameLogic.Config;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(7)]
    public class PlayerSeenItemRequirement : PlayerRequirement
    {
        [MetaMember(2, (MetaMemberFlags)0)]
        public int Requirement { get; set; }

        public PlayerSeenItemRequirement()
        {
        }

        public PlayerSeenItemRequirement(int itemRef)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef ItemDef { get; set; }
    }
}