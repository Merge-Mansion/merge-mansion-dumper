using Metaplay.Core.Model;
using Metaplay.Core.League.Player;
using System;
using Metaplay.Core;

namespace GameLogic.Player.Leaderboard
{
    [MetaSerializable]
    [MetaReservedMembers(1, 100)]
    public abstract class LeaderboardBotEventDivisionModel<TModel, TParticipantState, TAvatar> : PlayerDivisionModelBase<TModel, TParticipantState, PlayerDivisionScore, TAvatar>, ILeaderboardBotEventMatchmakingModel
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string EventId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaTime? MatchMakingEnded { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [ServerOnly]
        public MetaTime? MatchMakingStartTime { get; set; }
        public override int TicksPerSecond { get; }

        protected LeaderboardBotEventDivisionModel()
        {
        }
    }
}