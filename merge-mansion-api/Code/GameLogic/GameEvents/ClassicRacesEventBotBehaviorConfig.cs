using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class ClassicRacesEventBotBehaviorConfig : IGameConfigData<BotBehaviorId>, IGameConfigData, IHasGameConfigKey<BotBehaviorId>, IClassicRacesEventBotBehaviorConfig
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public BotBehaviorId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public float TargetScoreThresholdMultiplier { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int MinIntervalSeconds { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int PointMin { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int PointMax { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public float PointMultiplier { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public float NoScoreChance { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public float CatchUpDistanceMultiplier { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public float CatchUpPointMultiplier { get; set; }

        public ClassicRacesEventBotBehaviorConfig()
        {
        }
    }
}