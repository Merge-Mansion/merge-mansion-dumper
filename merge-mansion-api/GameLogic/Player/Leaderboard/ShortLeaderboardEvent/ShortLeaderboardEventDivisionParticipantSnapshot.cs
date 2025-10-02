using Metaplay.Core.Model;
using System;
using Metaplay.Core;

namespace GameLogic.Player.Leaderboard.ShortLeaderboardEvent
{
    [MetaSerializableDerived(1)]
    public class ShortLeaderboardEventDivisionParticipantSnapshot : LeaderboardBotEventDivisionParticipantSnapshot
    {
        private ShortLeaderboardEventDivisionParticipantSnapshot()
        {
        }

        public ShortLeaderboardEventDivisionParticipantSnapshot(int participantIndex, int score, string displayName)
        {
        }

        public ShortLeaderboardEventDivisionParticipantSnapshot(int participantIndex, int score, string displayName, EntityId playerId)
        {
        }
    }
}