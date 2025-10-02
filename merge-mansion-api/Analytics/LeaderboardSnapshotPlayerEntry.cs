using Metaplay.Core.Model;
using System.ComponentModel;
using Newtonsoft.Json;
using System;

namespace Analytics
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 1 })]
    public class LeaderboardSnapshotPlayerEntry
    {
        [JsonProperty("rank")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Rank")]
        public int Rank { get; set; }

        [JsonProperty("points")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Points")]
        public int Points { get; set; }

        [JsonProperty("association_id")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Association Id")]
        public string AssociationId { get; set; }

        private LeaderboardSnapshotPlayerEntry()
        {
        }

        public LeaderboardSnapshotPlayerEntry(string associationId, int rank, int points)
        {
        }

        [JsonProperty("bot_type")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Bot Type")]
        public string BotType { get; set; }

        public LeaderboardSnapshotPlayerEntry(string associationId, int rank, int points, string botType)
        {
        }
    }
}