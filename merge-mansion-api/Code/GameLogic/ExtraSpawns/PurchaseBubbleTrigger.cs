using Metaplay.Core.Model;
using System;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializableDerived(2)]
    public class PurchaseBubbleTrigger : IExtraSpawnTrigger
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int? Cost { get; set; }

        public PurchaseBubbleTrigger()
        {
        }

        public PurchaseBubbleTrigger(int? cost)
        {
        }
    }
}