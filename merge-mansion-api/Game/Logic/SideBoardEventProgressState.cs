using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;
using System;
using System.Collections.Generic;
using Metaplay.Core;

namespace Game.Logic
{
    [MetaSerializable]
    public class SideBoardEventProgressState
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public SideBoardEventId SideBoardEventId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public SideBoardEventStateReport CurrentState { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public Dictionary<int, SideBoardEventStateReport> ReportByEventLevel { get; set; }

        public SideBoardEventProgressState()
        {
        }
    }
}