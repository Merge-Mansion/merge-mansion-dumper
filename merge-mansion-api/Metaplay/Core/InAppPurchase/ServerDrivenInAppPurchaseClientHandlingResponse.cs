using Metaplay.Core.Model;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    public class ServerDrivenInAppPurchaseClientHandlingResponse
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaTime ReceivedAt { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public ServerDrivenInAppPurchaseClientHandlingResult Result { get; set; }
    }
}