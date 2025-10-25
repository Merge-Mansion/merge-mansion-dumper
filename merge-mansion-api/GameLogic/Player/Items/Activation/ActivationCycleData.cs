using Metaplay.Core.Model;
using System.Collections.Generic;
using Metaplay.Core;
using Metaplay.Core.Math;
using System;
using System.Runtime.Serialization;

namespace GameLogic.Player.Items.Activation
{
    [MetaSerializableDerived(1)]
    public class ActivationCycleData : IActivationCycleData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public List<MetaDuration> DelaysBetweenCycles { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<F64> TimerSkipMultiplier { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public List<int> ActivationAmountInCycle { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<int> HowManyAreGeneratedInCycle { get; set; }

        [IgnoreDataMember]
        public int CycleCount { get; }

        [IgnoreDataMember]
        public List<MetaDuration> GetDelaysBetweenCycles { get; }

        [IgnoreDataMember]
        public List<F64> GetTimerSkipMultiplier { get; }

        [IgnoreDataMember]
        public List<int> GetActivationAmountInCycle { get; }

        [IgnoreDataMember]
        public List<int> GetHowManyAreGeneratedInCycle { get; }
    }
}