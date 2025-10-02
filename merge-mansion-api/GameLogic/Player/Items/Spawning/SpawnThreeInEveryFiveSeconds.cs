using Metaplay.Core.Model;
using Metaplay.Core;
using System;

namespace GameLogic.Player.Items.Spawning
{
    [MetaSerializableDerived(3)]
    public class SpawnThreeInEveryFiveSeconds : ISpawnCycle
    {
        private static MetaDuration spawnDelay;
        private static MetaDuration firstCycleStartDelay;
        private static MetaDuration delayBetweenCycles;
        private static int howManyAreGeneratedPerSpawn;
        private static int spawnAmountInCycle;
        private static int howManyCycles;
        public SpawnThreeInEveryFiveSeconds()
        {
        }
    }
}