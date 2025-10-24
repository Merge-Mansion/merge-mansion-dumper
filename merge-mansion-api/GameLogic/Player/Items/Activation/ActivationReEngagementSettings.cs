using Metaplay.Core.Model;
using Metaplay.Core;
using System;
using Metaplay.Core.Math;

namespace GameLogic.Player.Items.Activation
{
    [MetaSerializableDerived(1)]
    public class ActivationReEngagementSettings : IActivationReEngagementSettings
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaDuration ReEngagementStarts { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaDuration ReEngagementEvery { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int ReEngagementMax { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaDuration AddsDelayBetweenCycles { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public F64 AddsTimerSkipMultiplier { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int AddsActivationAmountInCycle { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public int AddsHowManyAreGeneratedInCycle { get; set; }
    }
}