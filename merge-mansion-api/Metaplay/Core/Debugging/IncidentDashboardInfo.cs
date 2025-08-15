using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using Metaplay.Core.Network;

namespace Metaplay.Core.Debugging
{
    public class IncidentDashboardInfo
    {
        public IncidentDashboardInfo.ErrorDashboardInfo ErrorInfo;
        public IncidentDashboardInfo.NetworkDashboardInfo NetworkInfo;
        public IncidentDashboardInfo.PlayerModelDiffReportInfo PlayerModelDiffReport;
        public string IncidentId { get; set; }
        public MetaTime OccurredAt { get; set; }
        public List<ClientLogEntry> ClientLogEntries { get; set; }
        public UnitySystemInfo ClientSystemInfo { get; set; }
        public UnityPlatformInfo ClientPlatformInfo { get; set; }
        public IncidentGameConfigInfo GameConfigInfo { get; set; }
        public IncidentApplicationInfo ApplicationInfo { get; set; }
        public NetworkDiagnosticReport NetworkReport { get; set; }
        public DateTime UploadedAt { get; set; }
        public DateTime DeletionDateTime { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Reason { get; set; }
        public IncidentDashboardInfo.ExtraIncidentDashboardInfo ExtraInfo { get; set; }
        public PlayerIncidentReport RawReport { get; set; }

        [MetaSerializable((MetaSerializableFlags)1)]
        [MetaImplicitMembersDefaultRangeForMostDerivedClass(1, 100)]
        public abstract class ExtraIncidentDashboardInfo
        {
        }

        public class ErrorDashboardInfo
        {
            public string ErrorType { get; set; }
            public string ErrorMessage { get; set; }
            public string StackTrace { get; set; }
        }

        public class NetworkDashboardInfo
        {
            public string ServerHost { get; set; }
            public int ServerPort { get; set; }
            public bool EnableTls { get; set; }
            public string CdnBaseUrl { get; set; }
            public string NetworkReachability { get; set; }
            public string TlsPeerDescription { get; set; }
        }

        public class PlayerModelDiffReportInfo
        {
            public string PlayerModelDiff { get; set; }
        }
    }
}