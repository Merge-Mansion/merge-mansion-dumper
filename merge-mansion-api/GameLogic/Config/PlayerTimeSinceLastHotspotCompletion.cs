using Metaplay.Core.Model;
using Metaplay.Core.Player;
using Metaplay.Core;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1069)]
    public class PlayerTimeSinceLastHotspotCompletion : TypedPlayerPropertyId<MetaDuration>
    {
        public override string DisplayName { get; }
    }
}