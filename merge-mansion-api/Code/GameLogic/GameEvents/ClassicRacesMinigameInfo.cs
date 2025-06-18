using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Story;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class ClassicRacesMinigameInfo : IGameConfigData<CoreSupportEventMinigameId>, IGameConfigData, IHasGameConfigKey<CoreSupportEventMinigameId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CoreSupportEventMinigameId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<MetaRef<ClassicRacesEventStageInfo>> StageRefs { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public StoryDefinitionId IntroDialogue { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public StoryDefinitionId RaceLostDialogue { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public StoryDefinitionId EndedDialogue { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int AmountOfRacesInCup { get; set; }
        public int MaxRank { get; }

        public ClassicRacesMinigameInfo()
        {
        }

        public ClassicRacesMinigameInfo(CoreSupportEventMinigameId configKey, List<MetaRef<ClassicRacesEventStageInfo>> stageRefs, StoryDefinitionId introDialogue, StoryDefinitionId raceLostDialogue, StoryDefinitionId endedDialogue, int amountOfRacesInCup)
        {
        }
    }
}