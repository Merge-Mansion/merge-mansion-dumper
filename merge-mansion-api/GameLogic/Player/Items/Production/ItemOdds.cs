using Metaplay.Core;
using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;
using GameLogic.Config;

namespace GameLogic.Player.Items.Production
{
    [MetaSerializable]
    public class ItemOdds : IItemOdds
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef Type { get; set; } // 0x10

        [MetaMember(2, (MetaMemberFlags)0)]
        public int Weight { get; set; } // 0x18

        private ItemOdds()
        {
        }

        public ItemOdds(int type, int weight)
        {
        }

        [IgnoreDataMember]
        public int ConfigKey => Type.GetDef(ClientGlobal.SharedGameConfig).ConfigKey;

        public ItemOdds(ItemDefinition itemDefinition, int weight)
        {
        }
    }
}