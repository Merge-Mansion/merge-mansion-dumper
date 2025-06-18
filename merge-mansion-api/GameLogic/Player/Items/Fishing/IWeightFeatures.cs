using System;
using Metaplay.Core.Math;
using GameLogic.Story;
using System.Collections.Generic;
using GameLogic.Player.Rewards;
using Code.GameLogic.GameEvents;

namespace GameLogic.Player.Items.Fishing
{
    public interface IWeightFeatures
    {
        bool HasWeight { get; }

        F32 MinWeight { get; }

        F32 MaxWeight { get; }

        int FramesItem { get; }

        F32 WorldRecordWeightThreshold { get; }

        StoryDefinitionId WorldRecordWeightDialogue { get; }

        List<PlayerReward> WorldRecordRewards { get; }

        Dictionary<WeightCategory, SplashType> SplashTypesByWeightCategory { get; }

        FishRarity FishRarity { get; }

        List<WeightStarRewardData> StarRewards { get; }

        LuckyType LuckyType { get; }
    }
}