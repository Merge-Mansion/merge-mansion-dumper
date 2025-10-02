using Metaplay.Core.Model;
using System;

namespace Metaplay.Core
{
    [MetaSerializableDerived(12)]
    public class SocialAuthenticationClaimSteam : SocialAuthenticationClaimBase
    {
        public override AuthenticationPlatform Platform { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        public byte[] Ticket { get; set; }

        private SocialAuthenticationClaimSteam()
        {
        }

        public SocialAuthenticationClaimSteam(byte[] ticket)
        {
        }
    }
}