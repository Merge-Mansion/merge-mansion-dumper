using Metaplay.Core.Model;
using System;

namespace GameLogic.Config.Costs
{
    [MetaSerializableDerived(1)]
    public class GameCurrencyCost : CurrencyCost
    {
        [MetaMember(2, (MetaMemberFlags)0)]
        public Currencies Type { get; set; }
        public override Currencies Currency => Type;

        private GameCurrencyCost()
        {
        }

        public GameCurrencyCost(Currencies currencies, long currencyAmount)
        {
        }
    }
}