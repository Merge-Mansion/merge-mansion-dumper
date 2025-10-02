using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using System;

namespace Analytics
{
    [MetaSerializable]
    public class AnalyticsCurrencyCost
    {
        [JsonProperty("currency_code")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Code of the currency used for purchase")]
        public string CurrencyCode { get; set; }

        [JsonProperty("amount")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Amount of the currency used for purchase")]
        public double Amount { get; set; }

        public AnalyticsCurrencyCost()
        {
        }

        public AnalyticsCurrencyCost(string currencyCode, double amount)
        {
        }
    }
}