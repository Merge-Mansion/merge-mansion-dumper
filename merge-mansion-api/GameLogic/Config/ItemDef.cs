using Metaplay.Core.Model;
using Game.Cloud.Config;
using System;
using GameLogic.Player.Items;

namespace GameLogic.Config
{
    [MetaSerializableDerived(2)]
    public class ItemDef : ConfigDefinition<int, IItemDefinition>
    {
        private ItemDef()
        {
        }

        public ItemDef(int key)
        {
        }

        public override IItemDefinition? GetDef(IMergeMansionGameConfig config)
        {
            return !config.Items.TryGetValue(ConfigKey, out ItemDefinition item) ? null : item;
        }
    }
}