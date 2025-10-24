using Metaplay.Core.Model;
using GameLogic;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class RollTheDiceMinigameData : IRollTheDiceMinigameData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int RollTheDiceLevel { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public ValueTuple<int, int> CurrentBoardProgress { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public HashSet<int> ClaimedLevelRewards { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string CurrentRollTheDiceEventId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public RollTheDiceLevelId CurrentLevelId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public bool HasSeenIntroMinigameInfo { get; set; }
    }
}