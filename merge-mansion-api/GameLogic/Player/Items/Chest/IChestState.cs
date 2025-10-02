using System;
using GameLogic.Config.Types;

namespace GameLogic.Player.Items.Chest
{
    public interface IChestState
    {
        ulong ActivationCount { get; }

        ChestContext ChestContext { get; }

        MetacoreTime OpenStartTime { get; }

        MetacoreTime EstimatedEndTime { get; }
    }
}