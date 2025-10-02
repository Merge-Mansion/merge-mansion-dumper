using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using Metaplay.Core.Math;
using Metaplay.Core;
using System.Collections.Generic;

namespace GameLogic.Player.Modes
{
    public class EnergyModeSource : IConfigItemSource<EnergyModeInfo, PlayerModeId>, IGameConfigSourceItem<PlayerModeId, EnergyModeInfo>, IHasGameConfigKey<PlayerModeId>
    {
        public PlayerModeId ConfigKey { get; set; }
        private int EnergyConsumptionMultiplier { get; set; }
        private int CapacityConsumptionMultiplier { get; set; }
        private F32 LevelUpChance { get; set; }

        public EnergyModeSource()
        {
        }

        private int LevelUpCount { get; set; }
        private string NameLocId { get; set; }
        private List<string> EnableRequirementType { get; set; }
        private List<string> EnableRequirementId { get; set; }
        private List<string> EnableRequirementAmount { get; set; }
        private List<string> EnableRequirementAux0 { get; set; }
    }
}