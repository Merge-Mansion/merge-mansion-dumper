using Metaplay.Core.Model;
using GameLogic.Player.Items;
using Metaplay.Core;

namespace Code.GameLogic.Player
{
    [MetaSerializable]
    public interface IInventoryEntry
    {
        MergeItem Item { get; set; }

        MetaTime Timestamp { get; set; }
    }
}