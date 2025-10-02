using System;
using System.Collections.Generic;
using GameLogic.Player.Rewards;
using Merge;

namespace GameLogic.Player.Items.TheGreatEscape
{
    public interface IPrisonBadgeFeatures
    {
        bool IsBadge { get; }

        int CellItem { get; }

        PrisonerType Prisoner { get; }

        List<int> PrisonerLetters { get; }

        PlayerReward BadgeReward { get; }

        MergeBoardId TargetBoardId { get; }
    }
}