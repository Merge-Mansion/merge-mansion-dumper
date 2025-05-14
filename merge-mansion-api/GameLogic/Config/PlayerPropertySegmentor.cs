using Metaplay.Core.Model;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1060)]
    public class PlayerPropertySegmentor : PlayerPropertyMatcher<string>
    {
        public override string DisplayName { get; }

        public PlayerPropertySegmentor()
        {
        }
    }
}