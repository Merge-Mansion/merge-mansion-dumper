using System;
using System.Collections.Generic;
using GameLogic.Player.Items.Production;
using GameLogic.Player.Board.Placement;

namespace GameLogic.Player.Items.Fishing
{
    public interface IFishingRodFeatures
    {
        bool IsFishingRod { get; }

        List<ItemOdds> ItemOdds { get; }

        IPlacement Placement { get; }

        FishingRodRarity Rarity { get; }

        int[] FishWeightCategoryOddsOverrides { get; }

        int[] FishWeightCategorySizePercentagesOverrides { get; }

        int WaterDropletOverride { get; }
    }
}