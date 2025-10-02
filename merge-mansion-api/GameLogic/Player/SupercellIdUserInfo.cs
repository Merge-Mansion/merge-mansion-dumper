using Metaplay.Core.Model;
using Metaplay.Core.Authentication;
using System;

namespace GameLogic.Player
{
    [Obsolete("this was used with SupercellId SDK but not needed anymore for new links. This is kept only to be able to deserialize already linked players")]
    [MetaSerializableDerived(1)]
    public class SupercellIdUserInfo : IAuthenticationPlatformUserInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [ServerOnly]
        public string GameAccountId { get; }
        public string DisplayName { get; }
    }
}