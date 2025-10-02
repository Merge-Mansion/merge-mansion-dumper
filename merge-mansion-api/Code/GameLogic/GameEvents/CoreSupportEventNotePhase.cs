using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum CoreSupportEventNotePhase
    {
        Start = 0,
        End = 1
    }
}