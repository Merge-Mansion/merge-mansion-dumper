using Metaplay.Core.Analytics;
using Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace Metacore.MergeMansion.Analytics
{
    [AnalyticsEvent(223, "Player performed roll in the roll the dice event.", 1, null, true, true, false)]
    [AnalyticsEventKeywords(new string[] { "event" })]
    public class RollTheDiceRollEvent : AnalyticsServersideEventBase
    {
        [JsonProperty("level")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("level of the minigame")]
        public int Level;
        [JsonProperty("multiplier")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("multiplier of the roll")]
        public int Multiplier;
        [JsonProperty("outcome")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("outcome of the roll")]
        public List<AnalyticsRollTheDiceIngredientData> Outcome;
        [JsonProperty("requirement")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("requirement of the level")]
        public List<AnalyticsRollTheDiceIngredientData> Requirement;
        [JsonProperty("completed")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("True if the level is completed")]
        public bool Completed;
        public override AnalyticsEventType EventType { get; }
        public override string EventDescription { get; }
    }
}