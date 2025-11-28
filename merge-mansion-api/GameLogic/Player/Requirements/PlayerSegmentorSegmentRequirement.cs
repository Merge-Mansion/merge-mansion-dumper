using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(62)]
    public class PlayerSegmentorSegmentRequirement : PlayerRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string Segment { get; set; }
    }
}