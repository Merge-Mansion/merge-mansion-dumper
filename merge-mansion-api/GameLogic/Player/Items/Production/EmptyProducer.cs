using System;
using System.Collections.Generic;
using System.Linq;
using GameLogic.Random;
using Metaplay.Core.Math;
using Metaplay.Core.Model;
using System.Runtime.Serialization;

namespace GameLogic.Player.Items.Production
{
    [MetaSerializableDerived(10)]
    [MetaAllowNoSerializedMembers]
    public class EmptyProducer : IItemSpawner, IItemProducer
    {
        public int SpawnQuantity => 0;

        public F64 TimeSkipPriceGems(IGenerationContext context)
        {
            return new F64(0);
        }

        public IEnumerable<IItemDefinition> Produce(IGenerationContext context, int quantity)
        {
            return Enumerable.Empty<IItemDefinition>();
        }

        public EmptyProducer()
        {
        }
    }
}