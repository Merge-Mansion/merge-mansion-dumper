using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1064)]
    public class PlayerIsMysteryPassOnlyBuyer : TypedPlayerPropertyId<bool>
    {
        public override string DisplayName { get; }

        public PlayerIsMysteryPassOnlyBuyer()
        {
        }
    }
}