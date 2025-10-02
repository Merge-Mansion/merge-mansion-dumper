using Metaplay.Core.Model;
using Metaplay.Core.Player;
using GameLogic.Player;
using System;

namespace GameLogic
{
    [ModelAction(20229)]
    public class DigEventServerRevealTileClick : PlayerSynchronizedServerActionCore<PlayerModel>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int X;
        [MetaMember(2, (MetaMemberFlags)0)]
        public int Y;
        public DigEventServerRevealTileClick()
        {
        }

        public DigEventServerRevealTileClick(int x, int y)
        {
        }
    }
}