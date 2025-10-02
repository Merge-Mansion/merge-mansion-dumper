using Metaplay.Core.Model;

namespace Metaplay.Core.Player
{
    [ModelAction(10308)]
    public class SetPlatformSpecificData : PlayerSynchronizedServerActionCore<IPlayerModelBase>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private AuthenticationPlatform Platform { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private IPlatformSpecificData Data { get; set; }
    }
}