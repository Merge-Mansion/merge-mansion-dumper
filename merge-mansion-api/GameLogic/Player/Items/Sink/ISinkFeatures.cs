using System;

namespace GameLogic.Player.Items.Sink
{
    public interface ISinkFeatures
    {
        bool IsSink { get; }

        ISinkStateFactory Factory { get; }

        bool HideProgressBar { get; }

        bool HideUndiscoveredItemsInHints { get; }

        bool AllowReverseSinking { get; }
    }
}