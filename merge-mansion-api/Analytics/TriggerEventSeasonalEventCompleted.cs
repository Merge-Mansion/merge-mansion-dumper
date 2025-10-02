using Metaplay.Core.Analytics;
using System.ComponentModel;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;

namespace Analytics
{
    [AnalyticsEvent(3042, "Seasonal event completed", 1, null, false, false, true)]
    public class TriggerEventSeasonalEventCompleted : PlayerTriggerEvent
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("event_id")]
        [Description("Completed seasonal event")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public EventId EventId { get; set; }

        public TriggerEventSeasonalEventCompleted()
        {
        }

        public TriggerEventSeasonalEventCompleted(EventId eventId)
        {
        }
    }
}