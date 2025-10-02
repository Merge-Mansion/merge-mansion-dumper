using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using GameLogic.Story;

namespace Code.GameLogic.GameEvents
{
    public class ClassicRacesEventStageSource : IConfigItemSource<ClassicRacesEventStageInfo, ClassicRacesEventStageId>, IGameConfigSourceItem<ClassicRacesEventStageId, ClassicRacesEventStageInfo>, IHasGameConfigKey<ClassicRacesEventStageId>
    {
        public ClassicRacesEventStageId ConfigKey { get; set; }
        private int ScoreToWin { get; set; }
        private StoryDefinitionId RaceWonDialogueId { get; set; }
        private string RewardType { get; set; }
        private string RewardId { get; set; }

        public ClassicRacesEventStageSource()
        {
        }
    }
}