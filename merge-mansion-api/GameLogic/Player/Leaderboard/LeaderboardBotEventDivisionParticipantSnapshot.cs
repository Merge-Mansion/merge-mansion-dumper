using Metaplay.Core.Model;
using GameLogic.Player.Leaderboard.ShortLeaderboardEvent;
using Metaplay.Core.Serialization;
using System;

namespace GameLogic.Player.Leaderboard
{
    [MetaSerializable]
    [MetaReservedMembers(1, 100)]
    [MetaDeserializationConvertFromConcreteDerivedType(typeof(ShortLeaderboardEventDivisionParticipantSnapshot))]
    public abstract class LeaderboardBotEventDivisionParticipantSnapshot
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int ParticipantIndex { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int Score { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        protected LeaderboardBotEventDivisionParticipantSnapshot()
        {
        }

        public LeaderboardBotEventDivisionParticipantSnapshot(int participantIndex, int score, string displayName)
        {
        }
    }
}