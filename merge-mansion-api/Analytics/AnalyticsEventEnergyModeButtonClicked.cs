using Metaplay.Core.Analytics;
using System;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using GameLogic.Player.Modes;

namespace Analytics
{
    [AnalyticsEvent(215, "Energy Mode Button Clicked", 1, null, false, true, false)]
    public class AnalyticsEventEnergyModeButtonClicked : AnalyticsServersideEventBase
    {
        public override string EventDescription { get; }
        public override AnalyticsEventType EventType { get; }

        [JsonProperty("menu_name")]
        [MetaMember(1, (MetaMemberFlags)0)]
        public string MenuName { get; set; }

        [JsonProperty("ui_name")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public string UiName { get; set; }

        public AnalyticsEventEnergyModeButtonClicked()
        {
        }

        public AnalyticsEventEnergyModeButtonClicked(EnergyModeInfo energyModeInfo)
        {
        }
    }
}