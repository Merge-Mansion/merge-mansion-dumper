using Metaplay.Core;

namespace GameLogic.Config.Types
{
    public interface IMetacorePlayerTimeZoneInfo
    {
        public static MetaDuration MinimumUtcOffset;
        public static MetaDuration MaximumUtcOffset;
        MetaDuration CurrentUtcOffset { get; }
    }
}