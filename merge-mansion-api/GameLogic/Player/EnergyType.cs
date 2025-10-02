using Metaplay.Core.Model;

namespace GameLogic.Player
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum EnergyType
    {
        Default = 0,
        Secondary = 1,
        Tertiary = 2,
        None = 3,
        MysteryMachine = 4,
        MysteryMachineCoins = 5,
        SoloMilestoneProgress = 6,
        Quaternary = 7,
        DigEventTaps = 8
    }
}