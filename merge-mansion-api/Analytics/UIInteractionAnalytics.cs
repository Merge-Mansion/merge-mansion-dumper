using Metaplay.Core.Analytics;
using System;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Analytics
{
    [AnalyticsEvent(219, "UI Interaction", 1, null, false, true, false)]
    public class UIInteractionAnalytics : AnalyticsServersideEventBase
    {
        public override string EventDescription { get; }
        public override AnalyticsEventType EventType { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("menu_name")]
        [Description("The menu where the UI interaction ocurred")]
        public string MenuName { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("ui_name")]
        [Description("The name of the UI interaction")]
        public string UiName { get; set; }
    }
}