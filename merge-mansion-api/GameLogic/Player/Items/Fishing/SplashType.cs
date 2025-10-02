using Metaplay.Core.Model;

namespace GameLogic.Player.Items.Fishing
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum SplashType
    {
        None = 0,
        VeryTiny = 1,
        Tiny = 2,
        Medium = 3,
        Large = 4,
        VeryLarge = 5
    }
}