using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Player.Items;
using GameLogic.Config;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class GarageCleanupBoardRowInfo : IGameConfigData<GarageCleanupBoardRowId>, IGameConfigData, IHasGameConfigKey<GarageCleanupBoardRowId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public GarageCleanupBoardRowId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRefList")]
        public List<ItemDef> Items { get; set; }

        public GarageCleanupBoardRowInfo()
        {
        }

        public GarageCleanupBoardRowInfo(GarageCleanupBoardRowId boardId, List<MetaRef<ItemDefinition>> items)
        {
        }
    }
}