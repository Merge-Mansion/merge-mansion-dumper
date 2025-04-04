using System;
using System.Collections.Generic;

namespace GameLogic.Player.Items.Sinkable
{
    public interface ISinkableFeatures
    {
        bool IsSinkable { get; }

        List<ISinkInAction> SinkInActions { get; }
    }
}