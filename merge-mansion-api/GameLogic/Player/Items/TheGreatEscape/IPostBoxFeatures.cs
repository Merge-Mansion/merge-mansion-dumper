using System;
using System.Collections.Generic;

namespace GameLogic.Player.Items.TheGreatEscape
{
    public interface IPostBoxFeatures
    {
        bool IsPostBox { get; }

        Dictionary<int, int> SinkData { get; }
    }
}