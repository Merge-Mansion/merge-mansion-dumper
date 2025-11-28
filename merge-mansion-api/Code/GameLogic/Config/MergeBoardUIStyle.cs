using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.Config
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum MergeBoardUIStyle
    {
        Default = 0,
        MysteryMachine = 1,
        Empty = 2
    }
}