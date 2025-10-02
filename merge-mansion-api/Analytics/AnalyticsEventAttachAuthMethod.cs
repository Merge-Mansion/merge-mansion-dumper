using Metaplay.Core.Analytics;
using System.ComponentModel;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System;

namespace Analytics
{
    [AnalyticsEvent(120, "Attach authentication method", 1, null, false, true, false)]
    public class AnalyticsEventAttachAuthMethod : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("platform")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Platform whose auth method was attached")]
        public string Platform { get; set; }

        [JsonProperty("attached_auth_methods")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Attached authentication methods")]
        public string AuthenticationMethods { get; set; }

        [JsonProperty(PropertyName = "auth_status", DefaultValueHandling = (DefaultValueHandling)0)]
        public string AuthStatus { get; }
        public override string EventDescription { get; }

        public AnalyticsEventAttachAuthMethod()
        {
        }

        public AnalyticsEventAttachAuthMethod(string platform, string authenticationMethods)
        {
        }
    }
}