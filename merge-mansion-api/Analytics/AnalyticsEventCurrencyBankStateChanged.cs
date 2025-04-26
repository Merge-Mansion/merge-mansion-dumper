using Metaplay.Core.Analytics;
using System.ComponentModel;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using GameLogic.Banks;
using System;

namespace Analytics
{
    [AnalyticsEventKeywords(new string[] { "event" })]
    [AnalyticsEvent(162, "Currency Bank state changed", 1, null, true, true, false)]
    public class AnalyticsEventCurrencyBankStateChanged : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("bank_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Currency Bank Id from config")]
        public CurrencyBankId CurrencyBankId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("state")]
        [Description("Threshold value for this stash")]
        public CurrencyBankState CurrencyBankState { get; set; }

        [Description("Unique id for this players activation")]
        [JsonProperty("activation_id")]
        [MetaMember(3, (MetaMemberFlags)0)]
        public string ActivationId { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventCurrencyBankStateChanged()
        {
        }

        public AnalyticsEventCurrencyBankStateChanged(CurrencyBankId currencyBankId, CurrencyBankState currencyBankState, string activationId)
        {
        }
    }
}