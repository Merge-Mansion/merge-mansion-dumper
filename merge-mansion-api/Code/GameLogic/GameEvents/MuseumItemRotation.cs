using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.GameEvents
{
    [ForceExplicitEnumValues]
    [MetaSerializable]
    public enum MuseumItemRotation
    {
        None = 0,
        CW = 1,
        CCW = 2
    }
}