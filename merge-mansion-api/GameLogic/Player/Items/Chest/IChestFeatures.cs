using System;
using Metaplay.Core;
using GameLogic.Player.Items.Production;
using GameLogic.Config.Types;
using Metacore.MergeMansion.Common.Options;
using GameLogic.Fallbacks;

namespace GameLogic.Player.Items.Chest
{
    public interface IChestFeatures
    {
        bool IsChest { get; }

        MetaDuration OpenDuration { get; }

        int HowManyToRoll { get; }

        IItemProducer LootProducer { get; }

        string HintLocId { get; }

        Option<FallbackPlayerRewardId> FallbackChestIdOption { get; }
    }
}