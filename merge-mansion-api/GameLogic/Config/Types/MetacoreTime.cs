using System;

namespace GameLogic.Config.Types
{
    public struct MetacoreTime
    {
        public static MetacoreTime Epoch;
        public long MillisecondsSinceEpoch { get; }
    }
}