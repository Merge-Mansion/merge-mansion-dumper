using System.Collections.Generic;
using System.Linq;
using GameLogic.Random;
using Metaplay.Core.Math;
using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;

namespace GameLogic.Player.Items.Production
{
    [MetaSerializableDerived(4)]
    public class ControlledRandomProducer : IItemSpawner, IItemProducer
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public RollHistoryType RollType { get; set; } // 0x10

        [MetaMember(2, (MetaMemberFlags)0)]
        public int ItemType { get; set; } // 0x14

        [MetaMember(3, (MetaMemberFlags)0)]
        private List<ItemOdds> GenerationOdds { get; set; } // 0x18

        [IgnoreDataMember]
        public IEnumerable<ValueTuple<ItemDefinition, int>> Odds => GenerationOdds.Select(x => (x.Item, x.Weight));
        public int SpawnQuantity => 1;

        public F64 TimeSkipPriceGems(IGenerationContext context)
        {
            return GenerationOdds.Average(odds => odds.Type.Ref.TimeSkipPriceGems);
        }

        public IEnumerable<ItemDefinition> Produce(IGenerationContext context, int quantity)
        {
            return Enumerable.Range(0, quantity).Select(_ =>
            {
                var itemWeights = GenerationOdds.Select(y => (y.Type.Deref().ConfigKey, y.Weight)).ToList();
                var distribution = context.DistributionStates;
                var random = context.Random;
                var itemIndex = distribution.Roll(RollType, ItemType, itemWeights, random);
                return GenerationOdds[itemIndex].Type.Deref();
            });
        }

        private ControlledRandomProducer()
        {
        }

        public ControlledRandomProducer(RollHistoryType rollType, int itemId, List<ValueTuple<int, int>> oddsList)
        {
        }
    }
}