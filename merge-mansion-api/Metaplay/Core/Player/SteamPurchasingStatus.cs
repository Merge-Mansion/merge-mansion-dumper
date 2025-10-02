using Metaplay.Core.Model;

namespace Metaplay.Core.Player
{
    [MetaSerializable]
    public enum SteamPurchasingStatus
    {
        Locked = 0,
        Active = 1,
        Trusted = 2
    }
}