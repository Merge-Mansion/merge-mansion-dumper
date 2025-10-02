using Metaplay.Core.Model;
using Newtonsoft.Json;
using System;

namespace Metaplay.Core.Player
{
    [MetaSerializable]
    public class PlayerSessionDebugModeParameters
    {
        [JsonRequired]
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool EnableEntityDebugConfig;
        [JsonRequired]
        [MetaMember(2, (MetaMemberFlags)0)]
        public PlayerDebugIncidentUploadMode IncidentUploadMode;
        public PlayerSessionDebugModeParameters(bool enableEntityDebugConfig, PlayerDebugIncidentUploadMode incidentUploadMode)
        {
        }
    }
}