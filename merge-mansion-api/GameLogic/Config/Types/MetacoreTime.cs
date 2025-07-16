using System;

namespace GameLogic.Config.Types
{
    public struct MetacoreTime
    {
        public static MetacoreTime Epoch;
        public long MillisecondsSinceEpoch { get; }

        public static DateTime DateTimeEpoch;
        public static MetacoreTime Now { get; }
    }
}