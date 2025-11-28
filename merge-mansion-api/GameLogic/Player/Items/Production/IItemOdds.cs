using System;

namespace GameLogic.Player.Items.Production
{
    public interface IItemOdds
    {
        int Weight { get; }

        int ConfigKey { get; }
    }
}