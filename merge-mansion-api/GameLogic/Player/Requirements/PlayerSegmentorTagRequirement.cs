using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(63)]
    public class PlayerSegmentorTagRequirement : PlayerRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string Tag { get; set; }
    }
}