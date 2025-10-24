using Metaplay.Core.Analytics;
using GameLogic;
using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;

namespace Game.Logic
{
    [AnalyticsEvent(18, "Event Currency used", 1, null, true, false, false)]
    [AnalyticsEventKeywords(new string[] { "event", "buysell" })]
    public class PlayerEventUsedEventCurrency : PlayerEventUsedCurrencyBase
    {
        public override Currencies Currency { get; }

        [MetaMember(101, (MetaMemberFlags)0)]
        private EventCurrencyId EventCurrencyId { get; set; }
    }
}