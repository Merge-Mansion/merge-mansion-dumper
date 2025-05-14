using Metaplay.Core.Model;

namespace GameLogic.Player.Items
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum PortalType
    {
        None = 0,
        Board = 1,
        Minigame = 2
    }
}