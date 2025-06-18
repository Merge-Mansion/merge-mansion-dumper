using Metaplay.Core.Model;
using GameLogic.Player.Leaderboard.ShortLeaderboardEvent;
using Metaplay.Core.Serialization;
using Metaplay.Core.League;
using System;
using System.Collections.Generic;
using Metaplay.Core;

namespace GameLogic.Player.Leaderboard
{
    [MetaSerializable]
    [MetaReservedMembers(1, 100)]
    [MetaDeserializationConvertFromConcreteDerivedType(typeof(ShortLeaderboardEventDivisionHistoryEntry))]
    public abstract class LeaderboardBotDivisionHistoryEntry : PlayerDivisionHistoryEntryBase
    {
        protected LeaderboardBotDivisionHistoryEntry(EntityId divisionId, DivisionIndex divisionIndex, IDivisionRewards rewards, PlayerDivisionScore playerScore, int leaderboardPlacementIndex, List<LeaderboardBotEventDivisionParticipantSnapshot> participantSnapshots) : base(divisionId, divisionIndex, rewards)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        public PlayerDivisionScore PlayerScore { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int LeaderboardPlacementIndex { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public List<LeaderboardBotEventDivisionParticipantSnapshot> ParticipantSnapshots { get; set; }
    }
}