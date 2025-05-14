using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using Merge;
using Metaplay.Core.Math;
using GameLogic;
using Code.GameLogic.GameEvents;
using Metaplay.Core;
using GameLogic.Player.Items;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializable]
    public class ExtraSpawnInfo : IGameConfigData<string>, IGameConfigData, IHasGameConfigKey<string>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public IExtraSpawnTrigger Trigger { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private int? ItemMinLevel { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private int? ItemMaxLevel { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<string> EventFilters { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public List<string> IncludeTags { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<string> ExcludeTags { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<MergeBoardId> IncludeBoards { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public List<MergeBoardId> ExcludeBoards { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public F32 SpawnChance { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        private List<ValueTuple<Currencies, ExtraSpawnAmountRange, IExtraSpawnFormula>> SpawnCurrencies { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        private List<ValueTuple<CoreSupportEventTokenId, ExtraSpawnAmountRange, IExtraSpawnFormula>> SpawnTokens { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        private List<ValueTuple<MetaRef<ItemDefinition>, long>> SpawnItems { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public int VisualPriority { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        private CoreSupportEventSegmentFeature<CoreSupportEventExtraSpawnGroupId> SegmentFeature { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        private List<CoreSupportEventType> EventTypeFilters { get; set; }
        public Option<CoreSupportEventSegmentFeature<CoreSupportEventExtraSpawnGroupId>> SegmentFeatureOption { get; }

        public ExtraSpawnInfo()
        {
        }

        public ExtraSpawnInfo(string configKey, IExtraSpawnTrigger trigger, int? itemMinLevel, int? itemMaxLevel, List<string> eventFilters, List<string> includeTags, List<string> excludeTags, List<MergeBoardId> includeBoards, List<MergeBoardId> excludeBoards, F32 spawnChance, List<ValueTuple<Currencies, ExtraSpawnAmountRange, IExtraSpawnFormula>> spawnCurrencies, List<ValueTuple<CoreSupportEventTokenId, ExtraSpawnAmountRange, IExtraSpawnFormula>> spawnTokens, List<ValueTuple<MetaRef<ItemDefinition>, long>> spawnItems, int visualPriority, CoreSupportEventSegmentFeature<CoreSupportEventExtraSpawnGroupId> segmentFeature, List<CoreSupportEventType> eventTypeFilters)
        {
        }
    }
}