using Metaplay.Core.League.Player;
using Metaplay.Core.Model;
using System;
using Metaplay.Core.Player;
using Metaplay.Core;

namespace GameLogic.Player.Leaderboard.ShortLeaderboardEvent
{
    [MetaSerializableDerived(201)]
    public class ShortLeaderboardEventDivisionAvatar : LeaderboardBotEventDivisionAvatar
    {
        private ShortLeaderboardEventDivisionAvatar()
        {
        }

        public ShortLeaderboardEventDivisionAvatar(string displayName, string associationId, PlayerSegmentId playerSegmentId, int segmentIdPriority, string botType)
        {
        }

        public ShortLeaderboardEventDivisionAvatar(string displayName, string associationId, EntityId playerId, PlayerSegmentId playerSegmentId, int segmentIdPriority, string botType)
        {
        }
    }
}