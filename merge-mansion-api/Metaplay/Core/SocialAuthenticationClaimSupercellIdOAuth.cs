using Metaplay.Core.Model;
using System;

namespace Metaplay.Core
{
    [MetaSerializableDerived(101)]
    public class SocialAuthenticationClaimSupercellIdOAuth : SocialAuthenticationClaimBase
    {
        public override AuthenticationPlatform Platform { get; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string Code { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string RedirectUri { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string CodeVerifier { get; set; }
    }
}