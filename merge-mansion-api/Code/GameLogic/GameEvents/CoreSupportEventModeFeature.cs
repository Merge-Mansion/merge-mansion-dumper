using Metaplay.Core.Model;
using System.Collections.Generic;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class CoreSupportEventModeFeature
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private List<MetaRef<CoreSupportEventModeInfo>> _modeInfoRefs;
        public CoreSupportEventModeFeature()
        {
        }

        public CoreSupportEventModeFeature(List<MetaRef<CoreSupportEventModeInfo>> modeInfoRefs)
        {
        }
    }
}