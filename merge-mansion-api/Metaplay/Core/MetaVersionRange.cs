using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Metaplay.Core
{
    [MetaSerializable]
    public class MetaVersionRange
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int MinVersion { get; set; } // 0x0

        [MetaMember(2, (MetaMemberFlags)0)]
        public int MaxVersion { get; set; } // 0x4

        public MetaVersionRange()
        {
        }

        public MetaVersionRange(int minVersion, int maxVersion)
        {
            MinVersion = minVersion;
            MaxVersion = maxVersion;
        }

        [IgnoreDataMember]
        public IEnumerable<int> Enumerate { get; }
    }
}