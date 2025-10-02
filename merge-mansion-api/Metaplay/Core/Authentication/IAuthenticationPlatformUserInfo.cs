using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.Authentication
{
    [MetaSerializable]
    public interface IAuthenticationPlatformUserInfo
    {
        string DisplayName { get; }
    }
}