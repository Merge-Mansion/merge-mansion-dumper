using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using Code.GameLogic.Config;
using Metaplay.Core.Math;

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
    }
}