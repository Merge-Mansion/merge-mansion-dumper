using Metaplay.Core.Model;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(2)]
    public class ClassicRacesMinigameModel : ICoreSupportEventMinigameModel
    {
        [IgnoreDataMember]
        public ClassicRacesClientState ClientState;
        [MetaMember(1, (MetaMemberFlags)0)]
        public CoreSupportEventMinigameId MinigameId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private byte BoolFields { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public PlayerClassicRacesEventStageModel CurrentStageModel { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int RacesWon { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private ClassicRacesParticipantData[] LastSeenParticipantsData { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        private HashSet<int> RaceWonDialoguesCompleted { get; set; }

        [IgnoreDataMember]
        public Option<ClassicRacesParticipantData[]> LastSeenParticipantsDataOption { get; }
        public bool IntroDialogFinished { get; set; }
        public bool RaceLostDialogFinished { get; set; }
        public bool ExtraRacesPopupDisplayed { get; set; }
        public bool CurrentRaceResultsNoted { get; set; }

        public ClassicRacesMinigameModel()
        {
        }

        public ClassicRacesMinigameModel(CoreSupportEventMinigameId minigameId)
        {
        }
    }
}