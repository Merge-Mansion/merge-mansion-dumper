using System;

namespace Code.GameLogic.Player
{
    public interface IWritableProducerInventorySlotState
    {
        bool Unlocked { get; set; }

        bool Seen { get; set; }
    }
}