using Metaplay.Core.Model;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1067)]
    public class PlayerRecentUniqueDeviceCount : PlayerPropertyMatcher<int>
    {
        public override string DisplayName { get; }

        public PlayerRecentUniqueDeviceCount()
        {
        }
    }
}