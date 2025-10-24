using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Story;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class RollTheDiceMinigameInfo : IGameConfigData<CoreSupportEventMinigameId>, IGameConfigData, IHasGameConfigKey<CoreSupportEventMinigameId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CoreSupportEventMinigameId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<MetaRef<RollTheDiceLevelInfo>> LevelRefs { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public StoryDefinitionId IntroDialogue { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public StoryDefinitionId EndedDialogue { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int RollDefaultCost { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public RollTheDiceMultiplierId Multiplier { get; set; }
    }
}