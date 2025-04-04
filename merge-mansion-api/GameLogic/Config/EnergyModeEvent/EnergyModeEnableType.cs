using Metaplay.Core.Model;

namespace GameLogic.Config.EnergyModeEvent
{
    [ForceExplicitEnumValues]
    [MetaSerializable]
    public enum EnergyModeEnableType
    {
        Manual = 0,
        Auto = 1
    }
}