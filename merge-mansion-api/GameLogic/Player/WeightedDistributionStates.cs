using System;
using System.Collections.Generic;
using GameLogic.Player.Items.Production;
using GameLogic.Random.ControlledRandom;
using Metaplay.Core;
using Metaplay.Core.Math;
using Metaplay.Core.Model;

namespace GameLogic.Player
{
    [MetaSerializable]
    public class WeightedDistributionStates
    {
        private const string MergePrefix = "me_";
        private const string BubblePrefix = "bu_";
        private const string SpawnPrefix = "as_";
        private const string DecayPrefix = "ad_";
        private const string ActivationPrefix = "ms_";
        private const string ChestPrefix = "ch_";
        [MetaMember(1, (MetaMemberFlags)0)]
        private Dictionary<string, Weight[]> wdStates; // 0x10
        [MetaMember(2, (MetaMemberFlags)0)]
        private Dictionary<string, uint> wdChecksums; // 0x18
        public int Roll(RollHistoryType rollType, int markerItem, List<(int, int)> initialOddsList, RandomPCG rng)
        {
            var key = ToKey(rollType, markerItem);
            return Roll(key, initialOddsList, rng, wdStates, wdChecksums);
        }

        private string ToKey(RollHistoryType rollType, int markerItem)
        {
            switch (rollType)
            {
                case RollHistoryType.Activation:
                    return ActivationPrefix + markerItem;
                case RollHistoryType.Spawning:
                    return SpawnPrefix + markerItem;
                case RollHistoryType.Decaying:
                    return DecayPrefix + markerItem;
                case RollHistoryType.Merge:
                    return MergePrefix + markerItem;
                case RollHistoryType.Bubble:
                    return BubblePrefix + markerItem;
                case RollHistoryType.Chest:
                    return ChestPrefix + markerItem;
                default:
                    throw new ArgumentOutOfRangeException(nameof(rollType));
            }
        }

        private static int Roll(string key, List<(int, int)> initialOddsList, RandomPCG rng, IDictionary<string, Weight[]> wdStates, IDictionary<string, uint> wdChecksums)
        {
            var oddListHash = CalculateOddListHash(initialOddsList);
            WeightedDistribution distribution;
            int randomPick;
            if (wdStates.TryGetValue(key, out var weights))
            {
                if (wdChecksums.TryGetValue(key, out var checksum) && oddListHash == checksum)
                {
                    distribution = new WeightedDistribution(weights);
                    randomPick = distribution.PickRandom(rng);
                    wdStates[key] = distribution.GetWeights();
                    return randomPick;
                }
            }

            distribution = GenerateWeightedDistributionFromOddsList(initialOddsList);
            distribution.Initialize(rng);
            oddListHash = CalculateOddListHash(initialOddsList);
            wdChecksums[key] = oddListHash;
            randomPick = distribution.PickRandom(rng);
            wdStates[key] = distribution.GetWeights();
            return randomPick;
        }

        private static uint CalculateOddListHash(List<(int, int)> oddsList)
        {
            var result = 0u;
            foreach (var odd in oddsList)
                result += (uint)odd.Item1 + (uint)odd.Item2 * 14;
            return result;
        }

        private static WeightedDistribution GenerateWeightedDistributionFromOddsList(List<(int, int)> oddsList)
        {
            var weights = new List<F32>();
            foreach (var odd in oddsList)
            {
                if (odd.Item2 < 1)
                    throw new ArgumentException($"Invalid weight for item {odd.Item1}: {odd.Item2}, must be positive integer", nameof(oddsList));
                var weightF = F32.FromInt(odd.Item2);
                if (weightF != odd.Item2)
                    throw new ArgumentException($"Invalid weight for item {odd.Item1}: {odd.Item2}, conversion to F32 is broken: {weightF}", nameof(oddsList));
                weights.Add(weightF);
            }

            return new WeightedDistribution(weights);
        }

        public WeightedDistributionStates()
        {
        }

        [MetaMember(3, (MetaMemberFlags)0)]
        private Dictionary<string, int> wdSequenceIndexes;
        [MetaMember(4, (MetaMemberFlags)0)]
        private Dictionary<string, ulong> wdRandomSequenceSeeds;
        private static string SinkPrefix;
        private static string OrderPrefix;
    }
}