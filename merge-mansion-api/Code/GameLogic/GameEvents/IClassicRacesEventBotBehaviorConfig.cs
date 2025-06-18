using System;

namespace Code.GameLogic.GameEvents
{
    public interface IClassicRacesEventBotBehaviorConfig
    {
        BotBehaviorId ConfigKey { get; }

        float TargetScoreThresholdMultiplier { get; }

        int MinIntervalSeconds { get; }

        int PointMin { get; }

        int PointMax { get; }

        float PointMultiplier { get; }

        float NoScoreChance { get; }

        float CatchUpDistanceMultiplier { get; }

        float CatchUpPointMultiplier { get; }
    }
}