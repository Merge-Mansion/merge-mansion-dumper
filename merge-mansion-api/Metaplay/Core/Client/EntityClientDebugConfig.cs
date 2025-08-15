using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.Client
{
    [MetaSerializable]
    public class EntityClientDebugConfig
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool ClientConsistencyChecks { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public bool ClientEnableChecksumMismatchRollback { get; set; }
    }
}