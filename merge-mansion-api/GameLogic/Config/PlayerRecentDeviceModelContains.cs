using Metaplay.Core.Model;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1066)]
    public class PlayerRecentDeviceModelContains : PlayerPropertyMatcher<string>
    {
        public override string DisplayName { get; }

        public PlayerRecentDeviceModelContains()
        {
        }
    }
}