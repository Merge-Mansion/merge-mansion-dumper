using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using GameLogic.Random;
using Metaplay.Core.Math;

namespace GameLogic.Player.Items.Production
{
    [MetaSerializableDerived(18)]
    public class ControlledRandomSequenceProducer : IItemSpawner, IItemProducer
    {
        private static int MaxWeight;
        [MetaMember(1, (MetaMemberFlags)0)]
        public RollHistoryType RollType { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int ItemType { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int TotalWeight { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<ItemOdds> OddsList { get; set; }

        [IgnoreDataMember]
        public IEnumerable<ValueTuple<ItemDefinition, int>> Odds => OddsList.Select(x => (x.Item, x.Weight));

        public IEnumerable<ItemDefinition> Produce(IGenerationContext context, int quantity)
        {
            throw new NotImplementedException();
        }

        public int SpawnQuantity => 1;

        public F64 TimeSkipPriceGems(IGenerationContext context)
        {
            throw new NotImplementedException();
        }

        private ControlledRandomSequenceProducer()
        {
        }

        public ControlledRandomSequenceProducer(RollHistoryType rollType, int itemId, List<ValueTuple<int, int>> oddsList)
        {
        }
    }
}