using Metaplay.Core.League.Player;
using Metaplay.Core.Model;
using GameLogic.Player.Leaderboard.ShortLeaderboardEvent;
using Metaplay.Core.Serialization;
using System;
using Metaplay.Core.Player;

namespace GameLogic.Player.Leaderboard
{
    [PlayerLeaguesEnabledCondition]
    [MetaSerializable]
    [MetaReservedMembers(1, 100)]
    [MetaDeserializationConvertFromConcreteDerivedType(typeof(ShortLeaderboardEventDivisionAvatar))]
    public abstract class LeaderboardBotEventDivisionAvatar : PlayerDivisionAvatarBase, IMetacoreLeagueAvatar
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [ServerOnly]
        public string AssociationId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [ServerOnly]
        public PlayerSegmentId PlayerSegmentId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [ServerOnly]
        public int SegmentIdPriority { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        [ServerOnly]
        public string BotType { get; set; }

        protected LeaderboardBotEventDivisionAvatar()
        {
        }

        protected LeaderboardBotEventDivisionAvatar(string displayName, string associationId, PlayerSegmentId playerSegmentId, int segmentIdPriority, string botType)
        {
        }
    }
}