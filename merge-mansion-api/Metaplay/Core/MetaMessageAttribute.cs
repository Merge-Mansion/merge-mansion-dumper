using System;
using Metaplay.Core.Model;

namespace Metaplay.Core
{
    [AttributeUsage((AttributeTargets)4)]
    public class MetaMessageAttribute : Attribute, ISerializableTypeCodeProvider, ISerializableFlagsProvider
    {
        public readonly int MessageTypeCode; // 0x10
        public readonly MessageDirection Direction; // 0x14
        public int TypeCode => MessageTypeCode;
        public MetaSerializableFlags ExtraFlags { get; set; } // 0x18

        public MetaMessageAttribute(int typeCode, MessageDirection direction, bool hasExplicitMembers = false)
        {
            MessageTypeCode = typeCode;
            Direction = direction;
            ExtraFlags = MetaSerializableFlags.ImplicitMembers;
            if (hasExplicitMembers)
                ExtraFlags = MetaSerializableFlags.None;
        }
    }
}