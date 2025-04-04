using Metaplay.Core.Model;
using Metaplay.Core.Analytics;
using System.ComponentModel;
using Newtonsoft.Json;
using System;

namespace Analytics
{
    [AnalyticsEvent(153, "Player Requested for reset", 1, null, true, true, false)]
    [MetaBlockedMembers(new int[] { 1 })]
    public class AnalyticsEventPlayerInitiatedReset : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [Description("Previous Association Id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("old_association_id")]
        public string OldAssociationId { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventPlayerInitiatedReset()
        {
        }

        public AnalyticsEventPlayerInitiatedReset(string oldAssociationId)
        {
        }
    }
}