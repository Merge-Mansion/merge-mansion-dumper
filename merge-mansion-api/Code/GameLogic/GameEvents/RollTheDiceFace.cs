using Metaplay.Core.Model;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class RollTheDiceFace
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string Name { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private int Weight { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int Value { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string Ingredient { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private List<RollTheDiceSegmentedFaceWeights> SegmentWeight { get; set; }
    }
}