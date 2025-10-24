using System.Collections.Generic;
using GameLogic.Player.Items;
using Metaplay.Core;
using Metaplay.Core.Model;
using System;
using System.Linq;
using GameLogic.Config;

namespace GameLogic.MergeChains
{
    [MetaSerializableDerived(2)]
    public class ListMergeChainElement : IMergeChainElement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRefList")]
        public List<ItemDef> Items { get; set; }

        public int IndexOf(int itemId)
        {
            return Items.FindIndex(item => item.ConfigKey == itemId);
        }

        public bool Contains(int itemId)
        {
            return IndexOf(itemId) != -1;
        }

        public ItemDefinition First()
        {
            return ClientGlobal.SharedGameConfig.Items.GetValueOrDefault(Items.FirstOrDefault()?.ConfigKey ?? 0);
        }

        public ItemDefinition ElementAtOrDefault(int index)
        {
            return ClientGlobal.SharedGameConfig.Items.GetValueOrDefault(Items.ElementAtOrDefault(index)?.ConfigKey ?? 0);
        }

        private ListMergeChainElement()
        {
        }

        public ListMergeChainElement(IEnumerable<int> types)
        {
        }

        public ListMergeChainElement(IEnumerable<MetaRef<ItemDefinition>> items)
        {
        }

        public int Count { get; }
        public IEnumerable<ItemDef> AllItemDefs { get; }
    }
}