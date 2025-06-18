using Metaplay.Core.Model;
using System;
using Metaplay.Core.Player;

namespace GameLogic.Player.Leaderboard.ClassicRacesEvent
{
    [MetaSerializableDerived(301)]
    public class ClassicRacesEventDivisionAvatar : LeaderboardBotEventDivisionAvatar
    {
        public ClassicRacesEventDivisionAvatar()
        {
        }

        public ClassicRacesEventDivisionAvatar(string displayName, string associationId, PlayerSegmentId playerSegmentId, int segmentIdPriority, string botType)
        {
        }
    }
}