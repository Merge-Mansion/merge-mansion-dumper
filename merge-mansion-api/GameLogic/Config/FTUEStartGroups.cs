using Metaplay.Core.Model;

namespace GameLogic.Config
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum FTUEStartGroups
    {
        Default = 0,
        SkipVideo = 1,
        SkipVideoAndDialogues = 2
    }
}