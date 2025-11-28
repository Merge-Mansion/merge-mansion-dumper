using System.Collections.Generic;
using System.Linq;
using GameLogic.Random;
using Metaplay.Core.Math;
using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;

namespace GameLogic.Player.Items.Production
{
    [MetaSerializableDerived(2)]
    public class RandomProducer : IItemSpawner, IItemProducer
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public List<ItemOdds> OddsList { get; set; }
        public int SpawnQuantity => 1;

        public F64 TimeSkipPriceGems(IGenerationContext context)
        {
            return F64.FromDouble(OddsList.Average(odds => odds.Type.GetDef(ClientGlobal.SharedGameConfig).TimeSkipPriceGems.Double));
        }

        public IEnumerable<IItemDefinition> Produce(IGenerationContext context, int quantity)
        {
            // STUB
            yield break;
        }

        private RandomProducer()
        {
        }

        public RandomProducer(List<ValueTuple<int, int>> oddsList)
        {
        }
    }
}