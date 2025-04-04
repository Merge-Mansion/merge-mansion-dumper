using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using Metaplay.Core;
using GameLogic.Player.Modes;
using System.Collections.Generic;
using Metaplay.Core.Schedule;
using Metaplay.Core.Player;
using Code.GameLogic.GameEvents;

namespace GameLogic.Config.EnergyModeEvent
{
    public class EnergyModeEventSource : IConfigItemSource<EnergyModeEventInfo, EnergyModeEventId>, IGameConfigSourceItem<EnergyModeEventId, EnergyModeEventInfo>, IHasGameConfigKey<EnergyModeEventId>
    {
        public EnergyModeEventId ConfigKey { get; set; }
        private string DisplayName { get; set; }
        private string Description { get; set; }
        private List<MetaRef<PlayerSegmentInfo>> Segments { get; set; }
        private bool IsEnabled { get; set; }
        private MetaScheduleBase Schedule { get; set; }
        private string NameLocId { get; set; }
        private string UnlockRequirementType { get; set; }
        private string UnlockRequirementId { get; set; }
        private string UnlockRequirementAmount { get; set; }
        private string UnlockRequirementAux0 { get; set; }

        public EnergyModeEventSource()
        {
        }

        private string ContextCategory { get; set; }
        private string ContextSubCategory { get; set; }
        private bool IsTransient { get; set; }
        private EnergyModeEnableType EnergyModeEnableType { get; set; }
        private List<MetaRef<EnergyModeInfo>> EnergyModes { get; set; }
        private string PrefabsOverride { get; set; }
        private string StartPopupDescLocId { get; set; }
        private string EndPopupDescLocId { get; set; }
        private string TaskDescLocId { get; set; }
        private string InfoPopupDescLocId { get; set; }
        private EventGroupId GroupId { get; set; }
        private int Priority { get; set; }
    }
}