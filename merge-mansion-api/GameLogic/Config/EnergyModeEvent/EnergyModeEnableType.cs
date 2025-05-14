using Metaplay.Core.Model;

namespace GameLogic.Config.EnergyModeEvent
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum EnergyModeEnableType
    {
        Manual = 0,
        Auto = 1
    }
}