using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class AutoMergeSettings : GameConfigKeyValue<AutoMergeSettings>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool DefaultEnabledState { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public float AutoMergeInterval { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public float AutoMergeSpawnCooldown { get; set; }
    }
}