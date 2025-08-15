using Metaplay.Core.Model;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    public class ServerDrivenInAppPurchaseEventState
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaTime? InitiationFinishedAt { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public ServerDrivenInAppPurchaseClientHandlingResponse ClientResponse { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public MetaTime? RestoredAt { get; set; }
    }
}