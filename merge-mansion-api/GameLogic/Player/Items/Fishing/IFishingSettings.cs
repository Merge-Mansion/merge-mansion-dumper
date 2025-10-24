using System.Collections.Generic;
using System;

namespace GameLogic.Player.Items.Fishing
{
    public interface IFishingSettings
    {
        Dictionary<int, int> SmallFishWaterDropletCounts { get; }

        Dictionary<int, int> NonFishWaterDropletCounts { get; }

        int[] FishWeightCategoryOdds { get; }

        int[] FishWeightCategorySizePercentages { get; set; }
    }
}