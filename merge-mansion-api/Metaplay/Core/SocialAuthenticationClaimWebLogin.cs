using Metaplay.Core.Model;
using System;

namespace Metaplay.Core
{
    [MetaSerializableDerived(13)]
    public class SocialAuthenticationClaimWebLogin : SocialAuthenticationClaimBase
    {
        public override AuthenticationPlatform Platform { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        public string AccessToken { get; set; }
    }
}