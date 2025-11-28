using Metaplay.Core.Model;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System;
using GameLogic.Random;
using Metaplay.Core.Math;

namespace GameLogic.Player.Items.Production
{
    [MetaSerializableDerived(19)]
    public class InstantDecayProducer : IItemSpawner, IItemProducer
    {
        public int SpawnQuantity { get; }

        public InstantDecayProducer()
        {
        }

        public IEnumerable<IItemDefinition> Produce(IGenerationContext context, int quantity)
        {
            throw new NotImplementedException();
        }

        public F64 TimeSkipPriceGems(IGenerationContext context)
        {
            throw new NotImplementedException();
        }
    }
}