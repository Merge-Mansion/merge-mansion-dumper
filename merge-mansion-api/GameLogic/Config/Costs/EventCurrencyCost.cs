using Code.GameLogic.GameEvents;
using Metaplay.Core.Model;
using System;

namespace GameLogic.Config.Costs
{
    [MetaSerializableDerived(2)]
    public class EventCurrencyCost : CurrencyCost
    {
        [MetaMember(2, (MetaMemberFlags)0)]
        public EventCurrencyId EventCurrencyId { get; set; }
        public override Currencies Currency => Currencies.EventCurrency;

        private EventCurrencyCost()
        {
        }

        public EventCurrencyCost(EventCurrencyId eventCurrencyId, long currencyAmount)
        {
        }
    }
}