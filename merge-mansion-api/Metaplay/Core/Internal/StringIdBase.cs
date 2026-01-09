using System;

namespace Metaplay.Core.Internal
{
    public abstract class StringIdBase : IStringId
    {
        public string Value { get; set; }
    }
}