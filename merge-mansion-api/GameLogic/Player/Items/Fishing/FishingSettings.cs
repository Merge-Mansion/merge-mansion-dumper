using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;
using Code.GameLogic.Config;
using System.Runtime.Serialization;

namespace GameLogic.Player.Items.Fishing
{
    [MetaSerializable]
    public class FishingSettings : GameConfigKeyValue<FishingSettings>, IValidatable, IFishingSettings
    {
        [IgnoreDataMember]
        public IReadOnlyDictionary<int, int> SmallFishWaterDropletCounts { get; set; }

        [IgnoreDataMember]
        public IReadOnlyDictionary<int, int> NonFishWaterDropletCounts { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int[] FishWeightCategoryOdds { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int[] FishWeightCategorySizePercentages { get; set; }

        public FishingSettings()
        {
        }
    }
}