using Metaplay.Core.Model;
using Metaplay.Core.Player;

namespace Metaplay.Core.Message
{
    [MetaSerializable]
    public abstract class SessionForceTerminateReason
    {
        [MetaSerializableDerived(9)]
        public class MaintenanceModeStarted : SessionForceTerminateReason
        {
            public MaintenanceModeStarted()
            {
            }
        }

        [MetaSerializableDerived(10)]
        public class PauseDeadlineExceeded : SessionForceTerminateReason
        {
            public PauseDeadlineExceeded()
            {
            }
        }

        [MetaSerializableDerived(1)]
        public class ReceivedAnotherConnection : SessionForceTerminateReason
        {
            public ReceivedAnotherConnection()
            {
            }
        }

        protected SessionForceTerminateReason()
        {
        }

        [MetaSerializableDerived(2)]
        public class KickedByAdminAction : SessionForceTerminateReason
        {
            public KickedByAdminAction()
            {
            }
        }

        [MetaSerializableDerived(3)]
        public class InternalServerError : SessionForceTerminateReason
        {
            public InternalServerError()
            {
            }
        }

        [MetaSerializableDerived(4)]
        public class Unknown : SessionForceTerminateReason
        {
            public Unknown()
            {
            }
        }

        [MetaSerializableDerived(5)]
        public class ClientTimeTooFarBehind : SessionForceTerminateReason
        {
            public ClientTimeTooFarBehind()
            {
            }
        }

        [MetaSerializableDerived(6)]
        public class ClientTimeTooFarAhead : SessionForceTerminateReason
        {
            public ClientTimeTooFarAhead()
            {
            }
        }

        [MetaSerializableDerived(7)]
        public class SessionTooLong : SessionForceTerminateReason
        {
            public SessionTooLong()
            {
            }
        }

        [MetaSerializableDerived(8)]
        public class PlayerBanned : SessionForceTerminateReason
        {
            public PlayerBanned()
            {
            }

            [MetaMember(1, (MetaMemberFlags)0)]
            public PlayerBanInfo BanInfo { get; }
        }

        [MetaSerializableDerived(100)]
        public class PlayerInitiatedReset : SessionForceTerminateReason
        {
            public PlayerInitiatedReset()
            {
            }
        }

        [MetaSerializableDerived(101)]
        public class ConfigUpdate : SessionForceTerminateReason
        {
            public ConfigUpdate()
            {
            }
        }

        [MetaSerializableDerived(11)]
        public class GameConfigUpdated : SessionForceTerminateReason
        {
            public GameConfigUpdated()
            {
            }
        }

        [MetaSerializableDerived(12)]
        public class LogicVersionUpdated : SessionForceTerminateReason
        {
            public LogicVersionUpdated()
            {
            }
        }

        [MetaSerializableDerived(13)]
        public class DirectConnectionLost : SessionForceTerminateReason
        {
        }
    }
}