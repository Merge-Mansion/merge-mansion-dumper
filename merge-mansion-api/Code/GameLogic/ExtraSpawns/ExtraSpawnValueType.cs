using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum ExtraSpawnValueType
    {
        Item = 0,
        Currency = 1
    }
}