using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;

namespace Metacore
{
    [MetaSerializable]
    public class RestoreCountryCodeSettings : GameConfigKeyValue<RestoreCountryCodeSettings>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool Enabled { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string EndpointOverride { get; set; }

        public RestoreCountryCodeSettings()
        {
        }
    }
}