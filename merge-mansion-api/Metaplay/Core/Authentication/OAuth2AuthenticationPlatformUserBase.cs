using Metaplay.Core.Model;
using System;
using Metaplay.Core.Forms;

namespace Metaplay.Core.Authentication
{
    [MetaImplicitMembersRange(100, 200)]
    [MetaImplicitMembersDefaultRangeForMostDerivedClass(1, 100)]
    public abstract class OAuth2AuthenticationPlatformUserBase : IWebLoginAuthenticationPlatformUserInfo, IAuthenticationPlatformUserInfo
    {
        [MetaMember(100, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [ServerOnly]
        [ExcludeFromGdprExport]
        [MetaFormNotEditable]
        [MetaMember(101, (MetaMemberFlags)0)]
        public string WebLoginSessionId { get; set; }

        [ServerOnly]
        [MetaMember(102, (MetaMemberFlags)0)]
        public string UserId { get; set; }

        [ServerOnly]
        [ExcludeFromGdprExport]
        [MetaFormNotEditable]
        [MetaMember(103, (MetaMemberFlags)0)]
        public string AccessToken { get; set; }

        [ServerOnly]
        [ExcludeFromGdprExport]
        [MetaFormNotEditable]
        [MetaMember(104, (MetaMemberFlags)0)]
        public string RefreshToken { get; set; }

        [MetaSerializableDerived(101)]
        public class Default : OAuth2AuthenticationPlatformUserBase
        {
            [ServerOnly]
            [MetaMember(1, (MetaMemberFlags)0)]
            public string EmailAddress { get; set; }
        }
    }
}