using Metaplay.Core.Model;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1070)]
    public class PlayerPropertySegmentorTags : PlayerPropertyMatcher<string>
    {
        public override string DisplayName { get; }
    }
}