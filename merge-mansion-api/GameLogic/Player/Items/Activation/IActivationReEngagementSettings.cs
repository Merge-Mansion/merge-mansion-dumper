using Metaplay.Core.Model;
using Metaplay.Core;
using System;
using Metaplay.Core.Math;

namespace GameLogic.Player.Items.Activation
{
    [MetaSerializable]
    public interface IActivationReEngagementSettings
    {
        MetaDuration ReEngagementStarts { get; }

        MetaDuration ReEngagementEvery { get; }

        int ReEngagementMax { get; }

        MetaDuration AddsDelayBetweenCycles { get; }

        F64 AddsTimerSkipMultiplier { get; }

        int AddsActivationAmountInCycle { get; }

        int AddsHowManyAreGeneratedInCycle { get; }
    }
}