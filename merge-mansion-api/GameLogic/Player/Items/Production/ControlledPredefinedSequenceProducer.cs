using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using GameLogic.Random;
using Metaplay.Core.Math;
using System.Linq;

namespace GameLogic.Player.Items.Production
{
    [MetaSerializableDerived(16)]
    public class ControlledPredefinedSequenceProducer : IItemSpawner, IItemProducer
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public RollHistoryType RollType { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int ItemType { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private int TotalCount { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private List<ItemOdds> OddsList { get; set; }

        [IgnoreDataMember]
        public IEnumerable<ValueTuple<ItemDefinition, int>> Odds => OddsList.Select(x => (x.Item, x.Weight));

        public IEnumerable<ItemDefinition> Produce(IGenerationContext context, int quantity)
        {
            throw new NotImplementedException();
        }

        public int SpawnQuantity { get; }

        public F64 TimeSkipPriceGems(IGenerationContext context)
        {
            throw new NotImplementedException();
        }

        private ControlledPredefinedSequenceProducer()
        {
        }

        public ControlledPredefinedSequenceProducer(RollHistoryType rollType, int itemId, IEnumerable<ValueTuple<int, int>> oddsList)
        {
        }
    }
}