using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;
using System;

namespace GameLogic
{
    [MetaSerializableDerived(1)]
    public class DigEventMinigameRewardId : ICoreSupportEventMinigameRewardId
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DigEventId EventId;
        [MetaMember(2, (MetaMemberFlags)0)]
        public DigEventMuseumShelfId ShelfId;
        [MetaMember(3, (MetaMemberFlags)0)]
        public bool IsShiny;
        public DigEventMinigameRewardId()
        {
        }

        public DigEventMinigameRewardId(DigEventId eventId, DigEventMuseumShelfId shelfId, bool isShiny)
        {
        }
    }
}