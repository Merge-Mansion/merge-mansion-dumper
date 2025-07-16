using Metaplay.Core.Model;
using GameLogic;
using System;

namespace Code.GameLogic.IAP
{
    [MetaSerializable]
    public class InAppProductRewardCurrency
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public Currencies CurrencyType;
        [MetaMember(2, (MetaMemberFlags)0)]
        public int Amount;
        public InAppProductRewardCurrency()
        {
        }
    }
}