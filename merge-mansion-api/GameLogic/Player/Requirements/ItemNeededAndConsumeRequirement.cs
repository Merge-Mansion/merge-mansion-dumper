using System.Collections.Generic;
using GameLogic.Player.Items;
using Metaplay.Core;
using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;
using GameLogic.Config;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(16)]
    public class ItemNeededAndConsumeRequirement : PlayerRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private List<int> ItemTypes { get; set; }

        public ItemNeededAndConsumeRequirement()
        {
        }

        public ItemNeededAndConsumeRequirement(int itemType)
        {
        }

        public ItemNeededAndConsumeRequirement(IEnumerable<int> itemTypes)
        {
        }

        [IgnoreDataMember]
        public IReadOnlyCollection<int> Items { get; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemListRef")]
        public List<ItemDef> ItemDefs { get; set; }
        public ItemDef ItemDef { get; }
    }
}