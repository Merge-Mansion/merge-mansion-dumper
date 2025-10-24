using Metaplay.Core;
using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;
using Metacore.MergeMansion.Common.Options;

namespace GameLogic.Player.Items.Activation
{
    [MetaSerializableDerived(1)]
    [MetaBlockedMembers(new int[] { 3, 4, 5 })]
    public class ActivationCycle : IActivationCycle
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaDuration ActivationDelay { get; set; } // 0x10

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaDuration FirstCycleStartDelay { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int HowManyCycles { get; set; } // 0x30

        public MetaDuration GetActivationDelay()
        {
            return ActivationDelay;
        }

        public int InitialCycles()
        {
            return HowManyCycles;
        }

        private ActivationCycle()
        {
        }

        public ActivationCycle(long firstCycleStartDelay, int activationAmountInCycle, int howManyAreGeneratedInCycle, long activationDelay, long delayBetweenCycles, int howManyCycles)
        {
        }

        public ActivationCycle(MetaDuration firstCycleStartDelay, int activationAmountInCycle, int howManyAreGeneratedInCycle, MetaDuration activationDelay, MetaDuration delayBetweenCycles, int howManyCycles)
        {
        }

        [MetaMember(7, (MetaMemberFlags)0)]
        public IActivationCycleData DailyActivationCyclesData { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        private IActivationCycleData InitialActivationCyclesData { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        private IActivationReEngagementSettings ReEngagementSettings { get; set; }

        [IgnoreDataMember]
        public Option<IActivationCycleData> InitialActivationCyclesDataOption { get; }

        [IgnoreDataMember]
        public Option<IActivationReEngagementSettings> ReEngagementSettingsOption { get; }
    }
}