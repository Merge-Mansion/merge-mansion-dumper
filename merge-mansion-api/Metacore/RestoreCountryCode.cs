using System;

namespace Metacore
{
    public class RestoreCountryCode
    {
        private static int TimeoutMs;
        private static int TimeoutOnErrorMs;
        private static int MaxRetries;
        private static string PlayerPrefsLastResolvedIp;
        private static string PlayerPrefsConfig;
        private static RestoreCountryCode _instance;
        private RestoreCountryCode.Result? _cachedResult;
        public RestoreCountryCode()
        {
        }

        public enum StoredIpAddressKind
        {
            None = 0,
            ServiceCore = 1,
            CachedFallback = 2,
            Failed = 3
        }

        public struct Result
        {
            public string IpAddress;
            public RestoreCountryCode.StoredIpAddressKind StoredKind;
        }
    }
}