using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;

namespace Metaplay.Core.Activables
{
    [MetaSerializable]
    public class MetaActivableTimelineSettings : IGameConfigBuildTimeValidate
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string Color { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string Row { get; set; }
    }
}