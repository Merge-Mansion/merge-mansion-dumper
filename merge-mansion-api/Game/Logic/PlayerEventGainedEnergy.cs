using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using GameLogic.Player;
using System;
using GameLogic;

namespace Game.Logic
{
    [AnalyticsEvent(13, "Gained energy", 1, null, true, false, false)]
    [AnalyticsEventKeywords(new string[] { "energy" })]
    public class PlayerEventGainedEnergy : PlayerEventGainedCurrency
    {
        [MetaMember(100, (MetaMemberFlags)0)]
        public EnergyType EnergyType { get; set; }
        public override string EventDescription { get; }

        public PlayerEventGainedEnergy()
        {
        }

        public PlayerEventGainedEnergy(EnergyType type, long amount, CurrencySource currencySource, long total, AnalyticsContext context)
        {
        }
    }
}