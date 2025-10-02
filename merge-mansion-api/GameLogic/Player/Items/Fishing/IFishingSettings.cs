using System.Collections.Generic;
using System;

namespace GameLogic.Player.Items.Fishing
{
    public interface IFishingSettings
    {
        IReadOnlyDictionary<int, int> SmallFishWaterDropletCounts { get; }

        IReadOnlyDictionary<int, int> NonFishWaterDropletCounts { get; }

        int[] FishWeightCategoryOdds { get; }

        int[] FishWeightCategorySizePercentages { get; set; }
    }
}