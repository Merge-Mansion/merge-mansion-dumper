using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum CoreSupportEventTokenTarget
    {
        Default = 0,
        BackButton = 1
    }
}