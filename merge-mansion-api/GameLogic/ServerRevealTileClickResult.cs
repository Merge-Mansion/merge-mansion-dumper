using Metaplay.Core.Model;
using System;

namespace GameLogic
{
    [MetaSerializable]
    public class ServerRevealTileClickResult
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int X;
        [MetaMember(2, (MetaMemberFlags)0)]
        public int Y;
        [MetaMember(3, (MetaMemberFlags)0)]
        public string TreasureName;
        [MetaMember(4, (MetaMemberFlags)0)]
        public bool TreasureCompleted;
        [MetaMember(5, (MetaMemberFlags)0)]
        public bool EnergyConsumed;
        [MetaMember(6, (MetaMemberFlags)0)]
        public bool WasCompensated;
        [MetaMember(7, (MetaMemberFlags)0)]
        public bool WasAddedToMuseum;
        public ServerRevealTileClickResult()
        {
        }

        public ServerRevealTileClickResult(int x, int y, string treasureName, bool treasureCompleted, bool energyConsumed, bool wasCompensated, bool wasAddedToMuseum)
        {
        }
    }
}