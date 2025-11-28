using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.Config
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum MergeBoardDisplay
    {
        Default = 0,
        OnMap = 1
    }
}