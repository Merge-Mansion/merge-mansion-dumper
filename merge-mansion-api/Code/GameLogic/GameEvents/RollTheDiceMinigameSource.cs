using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Story;
using System;

namespace Code.GameLogic.GameEvents
{
    public class RollTheDiceMinigameSource : IConfigItemSource<RollTheDiceMinigameInfo, CoreSupportEventMinigameId>, IGameConfigSourceItem<CoreSupportEventMinigameId, RollTheDiceMinigameInfo>, IHasGameConfigKey<CoreSupportEventMinigameId>
    {
        public CoreSupportEventMinigameId ConfigKey { get; set; }
        private List<MetaRef<RollTheDiceLevelInfo>> Levels { get; set; }
        private StoryDefinitionId IntroDialogue { get; set; }
        private StoryDefinitionId EndedDialogue { get; set; }
        private int RollDefaultCost { get; set; }
        private RollTheDiceMultiplierId Multiplier { get; set; }
    }
}