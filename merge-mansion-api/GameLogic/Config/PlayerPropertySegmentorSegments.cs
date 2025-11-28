using Metaplay.Core.Model;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1060)]
    public class PlayerPropertySegmentorSegments : PlayerPropertyMatcher<string>
    {
        public override string DisplayName { get; }
    }
}