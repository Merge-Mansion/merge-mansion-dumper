using System;
using System.Collections.Generic;
using GameLogic.Random;
using Metaplay.Core.Math;
using Metaplay.Core.Model;

namespace GameLogic.Player.Items.Production
{
    [MetaSerializableDerived(12)]
    [MetaAllowNoSerializedMembers]
    public class GarageCleanupEventProducer : IItemSpawner, IItemProducer
    {
        public int SpawnQuantity => 1;

        public F64 TimeSkipPriceGems(IGenerationContext context)
        {
            // STUB
            return F64.FromInt(0);
        }

        public IEnumerable<IItemDefinition> Produce(IGenerationContext context, int quantity)
        {
            // STUB
            throw new NotImplementedException();
        }

        public GarageCleanupEventProducer()
        {
        }
    }
}