using Metaplay.Core;
using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Items.Spawning
{
    [MetaSerializableDerived(1)]
    public class SpawnCycle : ISpawnCycle
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaDuration SpawnDelay { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaDuration FirstCycleStartDelay { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public MetaDuration DelayBetweenCycles { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int HowManyAreGeneratedPerSpawn { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int SpawnAmountInCycle { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int HowManyCycles { get; set; }

        private SpawnCycle()
        {
        }

        public SpawnCycle(long firstCycleStartDelay, int spawnAmountInCycle, int howManyAreGeneratedInCycle, long spawnDelay, long delayBetweenCycles, int howManyCycles)
        {
        }

        public SpawnCycle(MetaDuration firstCycleStartDelay, int spawnAmountInCycle, int howManyAreGeneratedInCycle, MetaDuration spawnDelay, MetaDuration delayBetweenCycles, int howManyCycles)
        {
        }
    }
}