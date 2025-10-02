using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using System;
using Code.GameLogic.GameEvents;
using GameLogic;

namespace Analytics
{
    [MetaSerializable]
    public class GameResourceCost
    {
        [JsonProperty("virtual_currency_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Type of the currency used")]
        public Currencies Currency { get; set; }

        [JsonProperty("value")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Amount of the currency used")]
        public int Amount { get; set; }

        [JsonProperty("event_currency_id")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Amount of the currency used")]
        public EventCurrencyId EventCurrencyId { get; set; }

        public GameResourceCost()
        {
        }

        public GameResourceCost(Currencies currency, int amount, EventCurrencyId eventCurrencyId)
        {
        }
    }
}