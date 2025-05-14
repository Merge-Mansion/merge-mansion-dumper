using System;
using JetBrains.Annotations;

namespace Metacore.MergeMansion.Common.Options
{
    public readonly struct Option<TValue>
    {
        public static readonly Option<TValue> None;
        private readonly TValue _value;
        private static readonly bool IsValueType;
        [PublicAPI]
        public bool HasValue { get; }
    }
}