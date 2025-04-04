using System.Collections.Generic;

namespace GameLogic.Player.Items.OverrideSpawnChance
{
    public interface IOverrideSpawnChanceFeatures
    {
        List<OverrideSpawnChance> OverrideSpawnChances { get; }
    }
}