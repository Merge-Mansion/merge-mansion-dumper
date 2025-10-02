using Metaplay.Core.Model;

namespace GameLogic
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum LocationId
    {
        UnKnown = 0,
        GrandmaMansion = 1,
        Ranch = 2,
        MansionUnderground = 3,
        LevelEditor = 9999,
        TombUnderground = 4,
        MansionInterior = 5,
        Beach = 6,
        TinCanFactory = 7,
        WestWing = 8
    }
}