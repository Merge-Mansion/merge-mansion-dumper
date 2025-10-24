using Metaplay.Core;
using Metaplay.Core.Model;
using System;
using Metacore.MergeMansion.Common.Options;

namespace GameLogic.Player.Items.Activation
{
    [MetaSerializable]
    public interface IActivationCycle
    {
        MetaDuration GetActivationDelay();
        int InitialCycles();
        int HowManyCycles { get; }

        IActivationCycleData DailyActivationCyclesData { get; }

        Option<IActivationCycleData> InitialActivationCyclesDataOption { get; }

        Option<IActivationReEngagementSettings> ReEngagementSettingsOption { get; }
    }
}