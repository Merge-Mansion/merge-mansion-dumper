using Code.GameLogic.Config;
using System;
using Metaplay.Core.Config;
using System.Collections.Generic;
using Merge;
using Metaplay.Core.Math;
using GameLogic;
using Code.GameLogic.GameEvents;
using Metaplay.Core.Player;

namespace Code.GameLogic.ExtraSpawns
{
    public class ExtraSpawnSource : IConfigItemSource<ExtraSpawnInfo, string>, IGameConfigSourceItem<string, ExtraSpawnInfo>, IHasGameConfigKey<string>
    {
        public string ConfigKey { get; set; }
        private ExtraSpawnTriggerType Trigger { get; set; }
        private string TriggerArgs { get; set; }
        private int? ItemMinLevel { get; set; }
        private int? ItemMaxLevel { get; set; }
        private List<string> EventFilter { get; set; }
        private List<string> IncludeTag { get; set; }
        private List<string> ExcludeTag { get; set; }
        private List<MergeBoardId> IncludeBoard { get; set; }
        private List<MergeBoardId> ExcludeBoard { get; set; }
        private F32 SpawnChance { get; set; }
        private List<Currencies> SpawnCurrency { get; set; }
        private List<F32?> SpawnCurrencyAmountMin { get; set; }
        private List<F32?> SpawnCurrencyAmountMax { get; set; }
        private List<ExtraSpawnFormulaType> SpawnCurrencyFormula { get; set; }
        private List<CoreSupportEventTokenId> SpawnToken { get; set; }
        private List<F32?> SpawnTokenAmountMin { get; set; }
        private List<F32?> SpawnTokenAmountMax { get; set; }
        private List<ExtraSpawnFormulaType> SpawnTokenFormula { get; set; }
        private List<string> SpawnItem { get; set; }
        private List<long> SpawnItemAmount { get; set; }
        private int VisualPriority { get; set; }
        private PlayerSegmentId Segment { get; set; }
        private CoreSupportEventExtraSpawnGroupId Group { get; set; }
        private int SegmentPriority { get; set; }
        private List<CoreSupportEventType> EventTypeFilter { get; set; }

        public ExtraSpawnSource()
        {
        }

        private List<string> RequirementType { get; set; }
        private List<string> RequirementId { get; set; }
        private List<string> RequirementAmount { get; set; }
        private List<string> RequirementAux0 { get; set; }
    }
}