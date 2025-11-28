using GameLogic.Player.Items;
using Metaplay.Core;
using Metaplay.Core.Model;
using GameLogic.Config;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(13)]
    public class ItemNeededRequirement : PlayerRequirement
    {
        private ItemNeededRequirement()
        {
        }

        public ItemNeededRequirement(MetaRef<ItemDefinition> itemRef)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef ItemDef { get; set; }
    }
}