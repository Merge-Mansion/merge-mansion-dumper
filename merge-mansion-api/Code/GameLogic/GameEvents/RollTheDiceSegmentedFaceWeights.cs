using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class RollTheDiceSegmentedFaceWeights
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public PlayerSegmentId SegmentId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int Weight { get; set; }
    }
}