using GameLogic;
using Metaplay.Core.Model;

namespace Game.Logic
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum PlayerStep
    {
        None = 0,
        ShowHardTaskTooltip = 1,
        TaskGroupV2FTUECompleted = 2
    }
}