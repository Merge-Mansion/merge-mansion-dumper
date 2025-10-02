using Metaplay.Core.Model;
using System;
using Metaplay.Core.Player;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1067)]
    public class PlayerRecentUniqueDeviceCount : TypedPlayerPropertyId<int>
    {
        public override string DisplayName { get; }

        public PlayerRecentUniqueDeviceCount()
        {
        }
    }
}