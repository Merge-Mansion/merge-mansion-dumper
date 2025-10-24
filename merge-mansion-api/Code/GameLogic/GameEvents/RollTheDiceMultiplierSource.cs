using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents
{
    public class RollTheDiceMultiplierSource : IConfigItemSource<RollTheDiceMultiplierInfo, RollTheDiceMultiplierId>, IGameConfigSourceItem<RollTheDiceMultiplierId, RollTheDiceMultiplierInfo>, IHasGameConfigKey<RollTheDiceMultiplierId>
    {
        public RollTheDiceMultiplierId ConfigKey { get; set; }
        public List<int> Taps { get; set; }
        public List<int> MultiplierStep { get; set; }
        public List<int> TokensMinLevelValue { get; set; }
    }
}