using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace Game.Cloud.Player
{
    [MetaSerializableDerived(10008)]
    public class PlayerSegmentorCondition : PlayerCondition
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string Segment { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string Tag { get; set; }
    }
}