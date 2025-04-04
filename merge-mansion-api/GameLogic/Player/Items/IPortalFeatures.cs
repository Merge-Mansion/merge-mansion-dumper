using System;
using Merge;

namespace GameLogic.Player.Items
{
    public interface IPortalFeatures
    {
        bool IsPortal { get; }

        MergeBoardId TargetBoardId { get; }
    }
}