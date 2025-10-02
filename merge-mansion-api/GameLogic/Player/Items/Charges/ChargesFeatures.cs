using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Items.Charges
{
    [MetaSerializable]
    public class ChargesFeatures : IChargesFeatures
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool SupportsCharges { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int DefaultInitialCharges { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public ChargeMergeBehavior MergeBehavior { get; set; }

        public static ChargesFeatures NoCharges;
        public ChargesFeatures()
        {
        }

        public ChargesFeatures(bool supportsCharges, int defaultInitialCharges, ChargeMergeBehavior mergeBehavior)
        {
        }
    }
}