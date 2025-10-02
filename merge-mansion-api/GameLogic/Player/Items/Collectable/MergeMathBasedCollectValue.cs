using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Items.Collectable
{
    [MetaSerializableDerived(2)]
    public class MergeMathBasedCollectValue : ICalculateCollectValue
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public Currencies Currency { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int Multiplier { get; set; }

        private static int[] levelToValueConversion;
        private MergeMathBasedCollectValue()
        {
        }

        public MergeMathBasedCollectValue(Currencies currency)
        {
        }

        public MergeMathBasedCollectValue(Currencies currency, int multiplier)
        {
        }
    }
}