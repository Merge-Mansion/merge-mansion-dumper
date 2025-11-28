using Metaplay.Core.Model;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Player.Items;
using System;
using GameLogic.Config;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(48)]
    public class PlayerNoItemRequirement : PlayerRequirement
    {
        [MetaMember(2, (MetaMemberFlags)0)]
        private List<int> ItemTypes { get; set; }

        public PlayerNoItemRequirement()
        {
        }

        public PlayerNoItemRequirement(ItemDefinition definition)
        {
        }

        public PlayerNoItemRequirement(IEnumerable<int> itemIds)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemListRef")]
        private List<ItemDef> ItemDefs { get; set; }
    }
}