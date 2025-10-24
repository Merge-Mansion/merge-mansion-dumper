using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using System;
using System.Collections.Generic;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(22)]
    public class CoreSupportEventModel : MetaActivableState<CoreSupportEventId, CoreSupportEventInfo>, ICoreSupportEventModel, ILevelEventModel
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public sealed override CoreSupportEventId ActivableId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private ICoreSupportEventMinigameModel MinigameModel { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private int GivenPortalItemId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int Level { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int LevelProgress { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public List<LevelEventClaimedLevelData> ClaimedLevels { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        private byte BoolFields { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public CoreSupportEventModeId CurrentMode { get; set; }
        public bool StartNoted { get; set; }
        public bool EndNoted { get; set; }
        public ILevelEventInfo LevelEventInfo { get; }
        public ICoreSupportEventInfo CoreSupportEventInfo { get; }
        public Option<ICoreSupportEventMinigameModel> MinigameModelOption { get; }
        public CoreSupportEventId ConfigKey => ActivableId;

        private CoreSupportEventModel()
        {
        }

        public CoreSupportEventModel(CoreSupportEventInfo info)
        {
        }
    }
}