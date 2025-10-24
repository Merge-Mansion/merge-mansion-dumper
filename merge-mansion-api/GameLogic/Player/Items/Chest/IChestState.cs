using System;
using GameLogic.Config.Types;
using Metaplay.Core;

namespace GameLogic.Player.Items.Chest
{
    public interface IChestState
    {
        ulong ActivationCount { get; }

        ChestContext ChestContext { get; }

        MetaTime OpenStartTime { get; }

        MetaTime EstimatedEndTime { get; }
    }
}