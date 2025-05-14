using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class CoreSupportEventSegmentFeature<T>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private PlayerSegmentId SegmentId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public T GroupId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int Priority { get; set; }

        public CoreSupportEventSegmentFeature()
        {
        }

        public CoreSupportEventSegmentFeature(PlayerSegmentId segmentId, T groupId, int priority)
        {
        }
    }
}