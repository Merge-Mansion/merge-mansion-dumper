using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;
using Metaplay.Core.Serialization;

namespace Metaplay.Core.EventLog
{
    [MetaSerializable]
    public class AbstractTypeDeserializationFailureInfo<TPayloadBase>
    {
        private static int MaxPayloadBytesRetained;
        [MetaMember(1, (MetaMemberFlags)0)]
        public int PayloadBytesLength { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public byte[] PayloadBytesTruncated { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public string PayloadTypeName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string ExceptionType { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string ExceptionMessage { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int? UnknownClassTypeCode { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int? UnexpectedWireDataTypeValue { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public string UnexpectedWireDataTypeName { get; set; }

        [IgnoreDataMember]
        public string Description { get; }

        private AbstractTypeDeserializationFailureInfo()
        {
        }

        public AbstractTypeDeserializationFailureInfo(MetaMemberDeserializationFailureParams failureParams)
        {
        }
    }
}