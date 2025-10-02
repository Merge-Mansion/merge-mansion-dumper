using System;
using System.Collections.Generic;
using System.Linq;
using GameLogic.Random;
using Metaplay.Core;
using Metaplay.Core.Math;
using Metaplay.Core.Model;
using GameLogic.Player.Items.Activation;
using System.Runtime.Serialization;

namespace GameLogic.Player.Items.Production
{
    [MetaSerializableDerived(11)]
    public class PrefixProducer : IItemSpawner, IItemProducer
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string Marker { get; set; } // 0x10

        [MetaMember(2, (MetaMemberFlags)0)]
        private List<MetaRef<ItemDefinition>> Items { get; set; } // 0x18

        [MetaMember(3, (MetaMemberFlags)0)]
        public IItemSpawner BaseProducer { get; set; } // 0x20
        public int SpawnQuantity => BaseProducer.SpawnQuantity;

        [IgnoreDataMember]
        public IEnumerable<ValueTuple<ItemDefinition, int>> Odds => BaseProducer.Odds;

        public IEnumerable<ItemDefinition> Produce(IGenerationContext context, int quantity)
        {
            if (Items == null)
                throw new ArgumentNullException(nameof(Items));
            if (BaseProducer == null)
                throw new ArgumentNullException(nameof(BaseProducer));
            var markerIndex = context.SpawnState.GetIndexOf(Marker);
            var start = Items.Count - markerIndex;
            if (start == 0 || Items.Count < markerIndex)
                return BaseProducer.Produce(context, quantity);
            // Produce n items here, and afterwards produce remaining quantity in base producer
            var maxStart = Math.Max(start, 0);
            var localQuantity = Math.Min(quantity, maxStart);
            var remainingQuantity = Math.Max(quantity - localQuantity, 0);
            return Enumerable.Range(markerIndex, localQuantity).Select(x =>
            {
                context.SpawnState.IncreaseIndexOf(Marker);
                return Items[x].Deref();
            }).Concat(BaseProducer.Produce(context, remainingQuantity));
        }

        public F64 TimeSkipPriceGems(IGenerationContext context)
        {
            return BaseProducer.TimeSkipPriceGems(context);
        }

        private PrefixProducer()
        {
        }

        public PrefixProducer(string marker, IEnumerable<int> items, IItemSpawner baseProducer)
        {
        }

        public PrefixProducer(string marker, IEnumerable<MetaRef<ItemDefinition>> items, IItemSpawner baseProducer)
        {
        }

        [MetaMember(4, (MetaMemberFlags)0)]
        private InitialSequenceType InitialSequenceType { get; set; }

        public PrefixProducer(InitialSequenceType initialSequenceType, string marker, IEnumerable<int> items, IItemSpawner baseProducer)
        {
        }

        public PrefixProducer(InitialSequenceType initialSequenceType, string marker, IEnumerable<MetaRef<ItemDefinition>> items, IItemSpawner baseProducer)
        {
        }
    }
}