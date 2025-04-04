using System;
using System.Collections.Generic;
using Metaplay.Core.Math;

namespace GameLogic.Player.Items.Boosting
{
    public interface IBoosterFeatures
    {
        bool DoesBoost { get; }

        BoostAreaStyle BoostAreaStyle { get; }

        List<int> AffectedItemsSet { get; }

        F32 BoostFactor { get; }

        F32 SpawnBoostFactor { get; }
    }
}