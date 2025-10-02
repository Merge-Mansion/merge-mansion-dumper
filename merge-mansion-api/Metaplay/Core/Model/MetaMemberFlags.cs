using System;

namespace Metaplay.Core.Model
{
    [Flags]
    public enum MetaMemberFlags
    {
        None = 0,
        Hidden = 1 << 0,
        NoChecksum = 1 << 1,
        Transient = 1 << 2,
        ServerOnly = Hidden | NoChecksum,
        _LegacyDontUse_ExcludeFromGdprExport = 8,
        ExcludeFromEventLog = 16
    }
}