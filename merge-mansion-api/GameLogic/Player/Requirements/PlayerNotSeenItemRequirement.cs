using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.Player.Items;
using System;
using GameLogic.Config;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(49)]
    public class PlayerNotSeenItemRequirement : PlayerRequirement
    {
        public PlayerNotSeenItemRequirement()
        {
        }

        public PlayerNotSeenItemRequirement(int itemRef)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef ItemDef { get; set; }
    }
}