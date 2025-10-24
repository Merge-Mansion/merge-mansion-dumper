using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;
using System;

namespace GameLogic
{
    [MetaSerializableDerived(3)]
    public class RollTheDiceMinigameRewardId : ICoreSupportEventMinigameRewardId
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CoreSupportEventMinigameId EventId;
        [MetaMember(2, (MetaMemberFlags)0)]
        public DigEventMuseumShelfId ShelfId;
        [MetaMember(3, (MetaMemberFlags)0)]
        public bool IsShiny;
    }
}