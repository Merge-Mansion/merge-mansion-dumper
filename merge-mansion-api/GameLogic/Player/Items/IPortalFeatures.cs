using System;
using Merge;
using Metacore.MergeMansion.Common.Options;

namespace GameLogic.Player.Items
{
    public interface IPortalFeatures
    {
        bool IsPortal { get; }

        PortalType Type { get; }

        Option<MergeBoardId> TargetBoardIdOption { get; }
    }
}