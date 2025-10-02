using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic;
using Code.GameLogic.Config;
using Metaplay.Core.Math;
using System.Collections.Generic;
using Code.GameLogic.GameEvents;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializable]
    public class ExtraSpawnCurrencyValueInfo : IGameConfigData<Currencies>, IGameConfigData, IHasGameConfigKey<Currencies>, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public Currencies ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public F32 Value { get; set; }

        public ExtraSpawnCurrencyValueInfo()
        {
        }

        public ExtraSpawnCurrencyValueInfo(Currencies configKey, F32 value)
        {
        }

        [MetaMember(3, (MetaMemberFlags)0)]
        private Dictionary<Currencies, F32> CustomValuesByCurrency { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private Dictionary<CoreSupportEventTokenId, F32> CustomValuesByCoreSupportEventTokenId { get; set; }
    }
}