using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.MergeChains;
using GameLogic.Player.Items;
using GameLogic.Config;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(45)]
    public class MergeChainNoItemRequirement : PlayerRequirement
    {
        private MergeChainNoItemRequirement()
        {
        }

        public MergeChainNoItemRequirement(MetaRef<MergeChainDefinition> mergeChain, MetaRef<ItemDefinition> minItemRef, MetaRef<ItemDefinition> maxItemRef)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixMergeChainRef")]
        public MergeChainDef MergeChainDef { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef MinItemDef { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef MaxItemDef { get; set; }
    }
}