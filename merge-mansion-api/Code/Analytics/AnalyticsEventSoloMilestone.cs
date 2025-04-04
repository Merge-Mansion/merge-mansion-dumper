using Metaplay.Core.Analytics;
using Analytics;
using System;
using Newtonsoft.Json;
using System.ComponentModel;
using Metaplay.Core.Model;
using Metaplay.Core.Math;

namespace Code.Analytics
{
    [AnalyticsEvent(197, "Solo Milestone Token Received", 1, null, true, true, false)]
    [AnalyticsEventKeywords(new string[] { "event", "task" })]
    public class AnalyticsEventSoloMilestone : AnalyticsServersideEventBase
    {
        public override string EventDescription { get; }
        public override AnalyticsEventType EventType { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("event_id")]
        [Description("Event instance number, increments per event instance")]
        public string EventId { get; set; }

        [JsonProperty("token_rarity")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Rarity of token received")]
        public string TokenRarity { get; set; }

        [JsonProperty("current_milestone")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Current milestone of the event")]
        public int CurrentMilestone { get; set; }

        [Description("Source of token spawned")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [JsonProperty("token_spawn_source")]
        public string TokenSpawnSource { get; set; }

        [JsonProperty("token_source_name")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Source name of spawned token")]
        public string TokenSourceName { get; set; }

        [JsonProperty("token_base_amount")]
        [Description("Base amount of token received")]
        [MetaMember(6, (MetaMemberFlags)0)]
        public int TokenBaseAmount { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Currency of base am")]
        [JsonProperty("token_base_amount_currency")]
        public string TokenBaseAmountCurrency { get; set; }

        [Description("Token multiplier")]
        [JsonProperty("token_multiplier")]
        [MetaMember(8, (MetaMemberFlags)0)]
        public F32 TokenMultiplier { get; set; }

        [JsonProperty("token_amount")]
        [MetaMember(9, (MetaMemberFlags)0)]
        [Description("Amount of token received")]
        public int TokenAmount { get; set; }

        [JsonProperty("token_saldo")]
        [MetaMember(10, (MetaMemberFlags)0)]
        [Description("Amount of tokens after receiving new tokens")]
        public long TokenSaldo { get; set; }

        [JsonProperty("token_chance")]
        [Description("Chance of token spawned")]
        [MetaMember(11, (MetaMemberFlags)0)]
        public int TokenChance { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        [Description("Segement of milestones")]
        [JsonProperty("token_segment_for_points")]
        public string TokenSegmentForPoints { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        [Description("Segement of rewards")]
        [JsonProperty("tokens_segment_for_rewards")]
        public string TokenSegmentForRewards { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        [JsonProperty("new_milestone_reached")]
        [Description("New milestone reached")]
        public int NewMilestoneReached { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        [JsonProperty("max_milestone")]
        [Description("Max number of milestones")]
        public int MaxMilestones { get; set; }

        public AnalyticsEventSoloMilestone()
        {
        }

        public AnalyticsEventSoloMilestone(string eventId, string tokenRarity, int currentMilestone, string tokenSpawnSource, string tokenSourceName, int tokenBaseAmount, string tokenBaseAmountCurrency, F32 tokenMultiplier, int tokenAmount, long tokenSaldo, int tokenChance, string tokenSegmentForPoints, string tokenSegmentForRewards, int newMilestoneReached, int maxMilestones)
        {
        }
    }
}