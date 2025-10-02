using Metaplay.Core.Model;
using Metaplay.Core.Guild;
using System;
using System.Collections.Generic;

namespace Metaplay.Core.Player
{
    [MetaSerializable]
    [MetaReservedMembers(1, 100)]
    public class PlayerGuildStateCore : IPlayerGuildState
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [ServerOnly]
        public EntityId GuildId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [ServerOnly]
        public GuildCreationParamsBase PendingGuildCreation { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [ServerOnly]
        public int LastPendingGuildOpEpoch { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [ServerOnly]
        [ExcludeFromGdprExport]
        public Dictionary<int, GuildMemberGuildOpLogEntry> PendingGuildOps { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        [ServerOnly]
        public int LastPlayerOpEpoch { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        [ServerOnly]
        public int GuildMemberInstanceId { get; set; }

        public PlayerGuildStateCore()
        {
        }
    }
}