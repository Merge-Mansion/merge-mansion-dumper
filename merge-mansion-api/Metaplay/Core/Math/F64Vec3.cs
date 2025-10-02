using System;

namespace Metaplay.Core.Math
{
    public struct F64Vec3
    {
        public long RawX;
        public long RawY;
        public long RawZ;
        public static F64Vec3 Zero { get; }
        public static F64Vec3 One { get; }
        public static F64Vec3 Down { get; }
        public static F64Vec3 Up { get; }
        public static F64Vec3 Left { get; }
        public static F64Vec3 Right { get; }
        public static F64Vec3 Forward { get; }
        public static F64Vec3 Back { get; }
        public static F64Vec3 AxisX { get; }
        public static F64Vec3 AxisY { get; }
        public static F64Vec3 AxisZ { get; }
        public F64 X { get; set; }
        public F64 Y { get; set; }
        public F64 Z { get; set; }
    }
}