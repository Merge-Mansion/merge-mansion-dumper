using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum CoreSupportEventStartPopupAction
    {
        Default = 0,
        OpenMinigame = 1
    }
}