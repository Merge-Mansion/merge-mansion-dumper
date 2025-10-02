using System;

namespace Metaplay.Core.Authentication
{
    public interface IWebLoginAuthenticationPlatformUserInfo : IAuthenticationPlatformUserInfo
    {
        string WebLoginSessionId { get; }
    }
}