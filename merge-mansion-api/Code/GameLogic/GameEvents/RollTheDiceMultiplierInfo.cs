using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class RollTheDiceMultiplierInfo : IGameConfigData<RollTheDiceMultiplierId>, IGameConfigData, IHasGameConfigKey<RollTheDiceMultiplierId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public RollTheDiceMultiplierId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<int> Taps { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public List<int> MultiplierSteps { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<int> TokensMinLevelValue { get; set; }
    }
}