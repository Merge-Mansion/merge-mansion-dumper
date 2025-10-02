using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.Player.Items;
using System;
using System.Runtime.Serialization;
using GameLogic.Config;

namespace GameLogic.Hotspots.CardStack
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 4, 5 })]
    public class PlayCard
    {
        [MetaMember(2, (MetaMemberFlags)0)]
        public int Row { get; set; }

        public PlayCard()
        {
        }

        public PlayCard(int itemId, int row)
        {
        }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int Column { get; set; }

        public PlayCard(int itemId, int row, int column)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        public ItemDef ItemDef { get; set; }
    }
}