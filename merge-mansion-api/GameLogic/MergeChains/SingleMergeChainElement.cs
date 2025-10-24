using GameLogic.Player.Items;
using Metaplay.Core;
using Metaplay.Core.Model;
using System;
using GameLogic.Config;
using System.Collections.Generic;

namespace GameLogic.MergeChains
{
    [MetaSerializableDerived(1)]
    public class SingleMergeChainElement : IMergeChainElement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        public ItemDef Item { get; set; }

        private SingleMergeChainElement()
        {
        }

        public SingleMergeChainElement(int type)
        {
        }

        public SingleMergeChainElement(MetaRef<ItemDefinition> item)
        {
        }

        public int IndexOf(int itemId)
        {
            return Contains(itemId) ? 0 : -1;
        }

        public bool Contains(int itemId)
        {
            return Item.ConfigKey == itemId;
        }

        public ItemDefinition First()
        {
            return ClientGlobal.SharedGameConfig.Items.GetValueOrDefault(Item.ConfigKey);
        }

        public ItemDefinition ElementAtOrDefault(int index)
        {
            if (index != 0)
                return null;
            return ClientGlobal.SharedGameConfig.Items.GetValueOrDefault(Item.ConfigKey);
        }

        public int Count { get; }
        public IEnumerable<ItemDef> AllItemDefs { get; }
    }
}