using Metaplay.Core.Model;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(3)]
    public class AutoMergeMinigameModel : ICoreSupportEventMinigameModel
    {
        public CoreSupportEventMinigameId MinigameId { get; set; }

        [MetaMember(1, (MetaMemberFlags)0)]
        public bool IsAutoMergeEnabled { get; set; }
    }
}