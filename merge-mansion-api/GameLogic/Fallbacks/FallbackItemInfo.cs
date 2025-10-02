using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Metaplay.Core;
using GameLogic.Player.Items;
using GameLogic.Config;

namespace GameLogic.Fallbacks
{
    [MetaSerializable]
    public class FallbackItemInfo : IGameConfigData<FallbackItemId>, IGameConfigData, IHasGameConfigKey<FallbackItemId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public FallbackItemId ConfigKey { get; set; }

        public FallbackItemInfo()
        {
        }

        public FallbackItemInfo(FallbackItemId fallbackItemId, MetaRef<ItemDefinition> itemRef, MetaRef<ItemDefinition> fallbackItemRef, MetaRef<ItemDefinition> expiredItemRef)
        {
        }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        public ItemDef ItemDef { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        public ItemDef FallbackItemDef { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        public ItemDef ExpiredItemDef { get; set; }
    }
}