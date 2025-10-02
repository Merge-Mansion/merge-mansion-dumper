using System;
using System.Collections.Concurrent;
using System.ComponentModel;

namespace Metaplay.Core
{
    [TypeConverter(typeof(StringIdTypeConverter))]
    public abstract class StringId<TStringId> : IStringId where TStringId : new()
    {
        public string Value { get; set; }

        public static TStringId FromString(string value)
        {
            var v = new TStringId();
            typeof(StringId<TStringId>).GetProperty(nameof(IStringId.Value))?.SetValue(v, value);
            return v;
        }

        public bool Equals(TStringId other)
        {
            return Value == ((IStringId)other).Value;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is StringId<TStringId> idObj))
                return false;
            return Value == idObj.Value;
        }

        public override int GetHashCode()
        {
            return Value?.GetHashCode() ?? 0;
        }

        public override string ToString()
        {
            return Value;
        }

        public static bool operator ==(StringId<TStringId> a, StringId<TStringId> b) => a?.Value == b?.Value;
        public static bool operator !=(StringId<TStringId> a, StringId<TStringId> b) => a?.Value != b?.Value;
        private static ConcurrentDictionary<string, TStringId> s_interned;
        protected StringId()
        {
        }
    }
}