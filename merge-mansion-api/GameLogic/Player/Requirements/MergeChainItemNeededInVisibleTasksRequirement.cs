using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.Player.Items;
using GameLogic.Config;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(21)]
    public class MergeChainItemNeededInVisibleTasksRequirement : PlayerRequirement
    {
        private MergeChainItemNeededInVisibleTasksRequirement()
        {
        }

        public MergeChainItemNeededInVisibleTasksRequirement(MetaRef<ItemDefinition> minItemInChainRef)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef MinItemInChainDef { get; set; }
    }
}