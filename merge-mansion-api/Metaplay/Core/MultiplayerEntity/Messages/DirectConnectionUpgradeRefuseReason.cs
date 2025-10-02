using Metaplay.Core.Model;

namespace Metaplay.Core.MultiplayerEntity.Messages
{
    [MetaSerializable]
    public enum DirectConnectionUpgradeRefuseReason
    {
        Unknown = 0,
        DisabledInEntitySettings = 1,
        DisabledInServerSettings = 2,
        NoPublicIpOnServer = 3,
        ServerFailedToOpenPort = 4
    }
}