using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using Merge;
using System.Runtime.Serialization;
using GameLogic.Player.Items;
using Metaplay.Core;
using Game.Logic;
using Code.GameLogic.Player;

namespace GameLogic.Player
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 1, 2 })]
    public class BoardInventory : IBoardInventory
    {
        [MetaMember(3, (MetaMemberFlags)0)]
        public int Size { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private List<BoardInventory.InventoryEntry> Entries { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public MergeBoardId BoardId { get; set; }
        public int ItemCount { get; }
        public bool IsFull { get; }

        [IgnoreDataMember]
        public IEnumerable<MergeItem> MergeItems { get; }

        public BoardInventory()
        {
        }

        public BoardInventory(int initialSize)
        {
        }

        public BoardInventory(MergeBoardId boardId, int initialSize)
        {
        }

        [MetaSerializable]
        public class InventoryEntry : IInventoryEntry
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public MergeItem Item { get; set; }

            [MetaMember(2, (MetaMemberFlags)0)]
            public MetaTime Timestamp { get; set; }

            public InventoryEntry()
            {
            }
        }

        [MetaMember(6, (MetaMemberFlags)0)]
        public bool IsLocked { get; set; }
        public bool IsEmpty { get; }
        public InventoryContentChanged InventoryChanged { get; set; }

        [MetaSerializable]
        public class ProducerInventorySlotState : IWritableProducerInventorySlotState
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public bool Unlocked { get; set; }

            [MetaMember(2, (MetaMemberFlags)0)]
            public bool Seen { get; set; }

            public ProducerInventorySlotState()
            {
            }

            public ProducerInventorySlotState(bool unlocked)
            {
            }

            public ProducerInventorySlotState(bool unlocked, bool seen)
            {
            }
        }
    }
}