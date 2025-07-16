using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1068)]
    public class PlayerHasItemInTheGarageInventory : TypedPlayerPropertyId<int>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string ItemType;
        public override string DisplayName { get; }

        public PlayerHasItemInTheGarageInventory()
        {
        }

        public PlayerHasItemInTheGarageInventory(string itemType)
        {
        }
    }
}