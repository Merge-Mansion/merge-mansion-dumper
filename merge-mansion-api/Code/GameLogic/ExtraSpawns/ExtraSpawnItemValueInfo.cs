using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using Code.GameLogic.Config;
using Metaplay.Core.Math;
using GameLogic;
using System.Collections.Generic;
using Code.GameLogic.GameEvents;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializable]
    public class ExtraSpawnItemValueInfo : IGameConfigData<int>, IGameConfigData, IHasGameConfigKey<int>, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public F32 Value { get; set; }

        public ExtraSpawnItemValueInfo()
        {
        }

        public ExtraSpawnItemValueInfo(int configKey, F32 value)
        {
        }

        [MetaMember(3, (MetaMemberFlags)0)]
        [NoChecksum]
        private string ItemName { get; set; }

        public ExtraSpawnItemValueInfo(string configKey, F32 value)
        {
        }

        [MetaMember(4, (MetaMemberFlags)0)]
        private Dictionary<Currencies, F32> CustomValuesByCurrency { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private Dictionary<CoreSupportEventTokenId, F32> CustomValuesByCoreSupportEventTokenId { get; set; }
    }
}