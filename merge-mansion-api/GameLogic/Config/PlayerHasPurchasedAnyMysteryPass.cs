using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1065)]
    public class PlayerHasPurchasedAnyMysteryPass : TypedPlayerPropertyId<bool>
    {
        public override string DisplayName { get; }

        public PlayerHasPurchasedAnyMysteryPass()
        {
        }
    }
}