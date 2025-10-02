using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum ExtraSpawnFormulaType
    {
        None = 0,
        ExponentialLevelMultiplier = 1,
        BubbleCostMultiplier = 2,
        HotspotValue = 3,
        ItemValue = 4,
        ItemLevel = 5
    }
}