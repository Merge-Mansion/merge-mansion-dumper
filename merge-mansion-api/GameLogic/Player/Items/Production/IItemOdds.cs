using System;

namespace GameLogic.Player.Items.Production
{
    public interface IItemOdds
    {
        int Weight { get; }

        ItemDefinition Item { get; }

        int ConfigKey { get; }
    }
}