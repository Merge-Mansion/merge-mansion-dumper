using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Leaderboard.ClassicRacesEvent
{
    [MetaSerializableDerived(2)]
    public class ClassicRacesEventDivisionParticipantSnapshot : LeaderboardBotEventDivisionParticipantSnapshot
    {
        private ClassicRacesEventDivisionParticipantSnapshot()
        {
        }

        public ClassicRacesEventDivisionParticipantSnapshot(int participantIndex, int score, string displayName)
        {
        }
    }
}