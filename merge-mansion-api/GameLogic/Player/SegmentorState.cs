using Metaplay.Core.Model;
using System.Collections.Generic;
using System;

namespace GameLogic.Player
{
    [MetaSerializable]
    public class SegmentorState
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [ServerOnly]
        public bool MigratedToSegmentor { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public HashSet<string> Segments { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public HashSet<string> Tags { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public HashSet<string> ForcedSegments { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public HashSet<string> ForcedTags { get; set; }
    }
}