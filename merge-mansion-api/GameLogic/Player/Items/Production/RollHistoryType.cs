using Metaplay.Core.Model;

namespace GameLogic.Player.Items.Production
{
    [MetaSerializable]
    public enum RollHistoryType
    {
        None = 0,
        Activation = 1,
        Spawning = 2,
        Decaying = 3,
        Merge = 4,
        Bubble = 5,
        Chest = 6,
        Sink = 7,
        Order = 8
    }
}