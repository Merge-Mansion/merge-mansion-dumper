using System;

namespace Metaplay.Core
{
    public interface IStringId
    {
        string Value { get; }

        public static int MaxLength;
    }
}