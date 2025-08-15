using GameLogic.Player.Items;
using Metaplay.Core;
using Metaplay.Core.Config;
using Metaplay.Core.Model;
using GameLogic.Config;

namespace GameLogic.Codex
{
    [MetaSerializable]
    public class CodexCategoryInfo : IGameConfigData<CodexCategoryId>, IGameConfigData, IHasGameConfigKey<CodexCategoryId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CodexCategoryId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        public ItemDef IconItem { get; set; }

        public CodexCategoryInfo()
        {
        }

        public CodexCategoryInfo(CodexCategoryId configKey, MetaRef<ItemDefinition> iconItem)
        {
        }
    }
}