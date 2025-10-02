using Metaplay.Core.Model;
using Metaplay.Core.AuditLog;
using System;

namespace Metaplay.Core.Player
{
    [MetaSerializableDerived(9700)]
    public class PlayerDashboardActionAuditLogPayloadCore : PlayerEventPayloadBase
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public PlayerActionBase Content { get; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public sealed override string EventTitle { get; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public sealed override string EventDescription { get; }
    }
}