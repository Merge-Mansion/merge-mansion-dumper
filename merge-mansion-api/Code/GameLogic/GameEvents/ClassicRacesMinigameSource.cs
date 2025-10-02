using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Story;
using System;

namespace Code.GameLogic.GameEvents
{
    public class ClassicRacesMinigameSource : IConfigItemSource<ClassicRacesMinigameInfo, CoreSupportEventMinigameId>, IGameConfigSourceItem<CoreSupportEventMinigameId, ClassicRacesMinigameInfo>, IHasGameConfigKey<CoreSupportEventMinigameId>
    {
        public CoreSupportEventMinigameId ConfigKey { get; set; }
        private List<MetaRef<ClassicRacesEventStageInfo>> Stages { get; set; }
        private StoryDefinitionId IntroDialogue { get; set; }
        private StoryDefinitionId RaceLostDialogue { get; set; }
        private StoryDefinitionId EndedDialogue { get; set; }
        private int AmountOfRacesInCup { get; set; }

        public ClassicRacesMinigameSource()
        {
        }
    }
}