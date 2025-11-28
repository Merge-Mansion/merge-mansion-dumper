using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1071)]
    public class PlayerWildItemAmount : TypedPlayerPropertyId<int>
    {
        public override string DisplayName { get; }
    }
}