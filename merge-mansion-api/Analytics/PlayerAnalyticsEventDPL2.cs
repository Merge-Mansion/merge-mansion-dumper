using Metaplay.Core.Model;
using Newtonsoft.Json;
using System;
using Metaplay.Core;
using Metaplay.Core.Math;
using Metaplay.Core.Analytics;

namespace Analytics
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 1 })]
    public struct PlayerAnalyticsEventDPL2
    {
        [JsonProperty("analytics_event_name")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public string AnalyticsEventName;
        [JsonProperty("timestamp")]
        [MetaMember(3, (MetaMemberFlags)0)]
        public MetaTime ModelTime;
        [JsonProperty("unique_id")]
        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaUInt128 UniqueId;
        [JsonProperty("context")]
        [MetaMember(5, (MetaMemberFlags)0)]
        public AnalyticsContextBase Context;
        [JsonProperty("payload")]
        [MetaOnMemberDeserializationFailure("CreateAnalyticsEventDeserializationSubstitute")]
        [MetaMember(6, (MetaMemberFlags)0)]
        public AnalyticsEventBase Payload;
    }
}