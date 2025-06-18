using Metaplay.Core.League.Player;
using Metaplay.Core.League;
using System;

namespace GameLogic.Player.Leaderboard
{
    public abstract class LeaderboardBotEventDivisionParticipantState : PlayerDivisionParticipantStateBase<PlayerDivisionScore, PlayerDivisionScore, LeaderboardBotEventDivisionAvatar>, IMetacoreLeagueParticipantState, IPlayerDivisionParticipantState, IDivisionParticipantState
    {
        public override string ParticipantInfo { get; }

        protected LeaderboardBotEventDivisionParticipantState()
        {
        }
    }
}