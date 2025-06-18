using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1063)]
    public class PlayerHasPurchasedLastNMysteryPasses : TypedPlayerPropertyId<bool>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private int Count { get; set; }
        public override string DisplayName { get; }

        public PlayerHasPurchasedLastNMysteryPasses()
        {
        }

        public PlayerHasPurchasedLastNMysteryPasses(int count)
        {
        }
    }
}