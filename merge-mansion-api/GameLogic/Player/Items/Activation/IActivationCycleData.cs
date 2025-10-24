using Metaplay.Core.Model;
using System;
using Metaplay.Core;
using System.Collections.Generic;
using Metaplay.Core.Math;

namespace GameLogic.Player.Items.Activation
{
    [MetaSerializable]
    public interface IActivationCycleData
    {
        int CycleCount { get; }

        List<MetaDuration> GetDelaysBetweenCycles { get; }

        List<F64> GetTimerSkipMultiplier { get; }

        List<int> GetActivationAmountInCycle { get; }

        List<int> GetHowManyAreGeneratedInCycle { get; }
    }
}