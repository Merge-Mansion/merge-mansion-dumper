using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Code.GameLogic.Config;
using Metaplay.Core;
using GameLogic.Player.Items;
using GameLogic.MergeChains;
using System;
using System.Runtime.Serialization;
using GameLogic.Config;

namespace Code.GameLogic.DynamicEvents
{
    [MetaSerializable]
    public class DynamicEventItemInfo : IGameConfigData<DynamicEventItemId>, IGameConfigData, IHasGameConfigKey<DynamicEventItemId>, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DynamicEventItemId ConfigKey { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int LevelNumber { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int TotalToLvl1 { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int[] DefaultValues { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public int[] DifficultyValues { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public int RewardPoints { get; set; }

        public DynamicEventItemInfo()
        {
        }

        public DynamicEventItemInfo(DynamicEventItemId configKey, string itemRef, MergeChainId mergeChain, int levelNumber, int totalToLvl1, int rewardpoints, int[] defaultValues, int[] difficultyValues)
        {
        }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef ItemDef { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixMergeChainRef")]
        public MergeChainDef MergeChainDef { get; set; }
    }
}