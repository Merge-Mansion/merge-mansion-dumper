using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum CoreSupportEventType
    {
        None = 0,
        DigEvent = 1,
        ClassicRaces = 2,
        AutoMerge = 3
    }
}