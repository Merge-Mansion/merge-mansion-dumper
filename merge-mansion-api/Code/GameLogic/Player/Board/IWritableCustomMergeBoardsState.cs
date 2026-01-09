using System.Collections.Generic;
using Merge;
using GameLogic.Player.Board;

namespace Code.GameLogic.Player.Board
{
    public interface IWritableCustomMergeBoardsState
    {
        SortedDictionary<MergeBoardId, MergeBoard> MergeBoards { get; }
    }
}