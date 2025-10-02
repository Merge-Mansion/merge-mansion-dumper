using System;
using Code.GameLogic.GameEvents;

namespace GameLogic.Player.Items.Leaderboard
{
    public interface ILeaderboardFeatures
    {
        bool HasLeaderboardFeatures { get; }

        int ScoreContribution { get; }

        LeaderboardEventId EventId { get; }
    }
}