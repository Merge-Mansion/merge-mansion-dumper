using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using Code.GameLogic.Config;
using Metaplay.Core;
using GameLogic.Player.Items;
using Metaplay.Core.Math;
using GameLogic.Config;

namespace GameLogic.Player.Modes
{
    [MetaSerializable]
    public class EnergyModeProgressionEventItemInfo : IGameConfigData<int>, IGameConfigData, IHasGameConfigKey<int>, IValidatable
    {
        [MetaMember(2, (MetaMemberFlags)0)]
        public F32 SpawnChance { get; set; }
        public int ConfigKey => ItemDef.ConfigKey;

        public EnergyModeProgressionEventItemInfo()
        {
        }

        public EnergyModeProgressionEventItemInfo(MetaRef<ItemDefinition> itemRef, F32 spawnChance)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef ItemDef { get; set; }
    }
}