using Metaplay.Core.Model;
using Metaplay.Core.Authentication;
using System;

namespace GameLogic.Player
{
    [MetaSerializableDerived(1)]
    public class SupercellIdUserInfo : IAuthenticationPlatformUserInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [ServerOnly]
        public string GameAccountId { get; }
        public string DisplayName { get; }
    }
}