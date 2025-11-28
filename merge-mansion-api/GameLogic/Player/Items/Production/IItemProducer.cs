using System;
using System.Collections.Generic;
using GameLogic.Random;
using Metaplay.Core.Model;

namespace GameLogic.Player.Items.Production
{
    [MetaSerializable]
    public interface IItemProducer
    {
        // Slot 1
        IEnumerable<IItemDefinition> Produce(IGenerationContext context, int quantity);
    }
}