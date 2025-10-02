using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Code.GameLogic.GameEvents;
using Metaplay.Core;
using System;
using System.Collections.Generic;

namespace GameLogic.Player.Events.AdStampCardEvent
{
    [MetaSerializable]
    public class AdStampCardEventModel : MetaActivableState<AdStampCardEventId, AdStampCardEventInfo>, ICoreSupportingEventModel
    {
        [MetaMember(3, (MetaMemberFlags)0)]
        private MetaTime startTime;
        [MetaMember(4, (MetaMemberFlags)0)]
        private int currentDay;
        [MetaMember(5, (MetaMemberFlags)0)]
        private int totallAdsWatched;
        [MetaMember(6, (MetaMemberFlags)0)]
        private int totallAdsWatchedToday;
        [MetaMember(7, (MetaMemberFlags)0)]
        private Dictionary<int, int> totallAdsWatchedPerDay;
        [MetaMember(8, (MetaMemberFlags)0)]
        private int potentialDay;
        [MetaMember(9, (MetaMemberFlags)0)]
        private int realCurrentDay;
        [MetaMember(10, (MetaMemberFlags)0)]
        private bool claimedReward;
        [MetaMember(11, (MetaMemberFlags)0)]
        private Dictionary<int, int> stampsMarked;
        [MetaMember(12, (MetaMemberFlags)0)]
        public bool RewardMailTriggered;
        [MetaMember(1, (MetaMemberFlags)0)]
        public sealed override AdStampCardEventId ActivableId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private byte BoolFields { get; set; }
        public bool PreviewNoted { get; set; }
        public bool StartNoted { get; set; }
        public bool EndNoted { get; set; }
        public bool AdStampCardUnlocked { get; set; }
        public bool RequiresPlayerAttention { get; }

        private AdStampCardEventModel()
        {
        }

        public AdStampCardEventModel(AdStampCardEventInfo info)
        {
        }
    }
}