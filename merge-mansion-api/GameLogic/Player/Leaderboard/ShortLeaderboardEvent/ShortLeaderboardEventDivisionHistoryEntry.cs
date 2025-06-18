using Metaplay.Core.Model;
using Metaplay.Core;
using Metaplay.Core.League;
using System;
using System.Collections.Generic;

namespace GameLogic.Player.Leaderboard.ShortLeaderboardEvent
{
    [MetaSerializableDerived(3)]
    public class ShortLeaderboardEventDivisionHistoryEntry : LeaderboardBotDivisionHistoryEntry
    {
        public ShortLeaderboardEventDivisionHistoryEntry(EntityId divisionId, DivisionIndex divisionIndex, IDivisionRewards rewards, PlayerDivisionScore playerScore, int leaderboardPlacementIndex, List<LeaderboardBotEventDivisionParticipantSnapshot> participantSnapshots) : base(divisionId, divisionIndex, rewards, playerScore, leaderboardPlacementIndex, participantSnapshots)
        {
        }
    }
}