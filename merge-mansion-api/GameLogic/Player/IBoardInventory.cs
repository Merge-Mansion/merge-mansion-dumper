using Metaplay.Core.Model;
using System;
using Merge;
using Game.Logic;
using System.Collections.Generic;
using GameLogic.Player.Items;

namespace GameLogic.Player
{
    [MetaSerializable]
    public interface IBoardInventory
    {
        int Size { get; set; }

        MergeBoardId BoardId { get; }

        bool IsLocked { get; set; }

        int ItemCount { get; }

        bool IsFull { get; }

        bool IsEmpty { get; }

        InventoryContentChanged InventoryChanged { get; set; }

        IEnumerable<MergeItem> MergeItems { get; }
    }
}