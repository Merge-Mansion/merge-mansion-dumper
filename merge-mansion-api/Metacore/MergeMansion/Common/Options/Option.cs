using System;
using JetBrains.Annotations;

namespace Metacore.MergeMansion.Common.Options
{
    public readonly struct Option<TValue>
    {
        private readonly TValue _value;
        [PublicAPI]
        public bool HasValue { get; }

        public static readonly Option<TValue> NONE;
        private static readonly bool IS_VALUE_TYPE;
    }
}