using Code.GameLogic.GameEvents;
using Game.Logic;
using GameLogic.Config;
using GameLogic.Player;
using Metaplay.Core;
using System;

namespace GameLogic.Random
{
    public interface IGenerationContext
    {
        Statistics Statistics { get; }

        WeightedDistributionStates DistributionStates { get; }

        SpawnFactoryState SpawnState { get; }

        RandomPCG Random { get; }

        [Obsolete("use MergeMansionGameConfig instead")]
        SharedGameConfig GameConfig { get; }

        GarageCleanupEventModel GarageCleanupEventModel { get; }

        IMergeMansionGameConfig MergeMansionGameConfig { get; }
    }
}