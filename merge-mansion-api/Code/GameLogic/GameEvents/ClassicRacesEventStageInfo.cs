using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using GameLogic.Player.Rewards;
using GameLogic.Story;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class ClassicRacesEventStageInfo : IGameConfigData<ClassicRacesEventStageId>, IGameConfigData, IHasGameConfigKey<ClassicRacesEventStageId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public ClassicRacesEventStageId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int ScoreToWin { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public PlayerReward Reward { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public StoryDefinitionId RaceWonDialogueId { get; set; }

        public ClassicRacesEventStageInfo()
        {
        }

        public ClassicRacesEventStageInfo(ClassicRacesEventStageId configKey, int scoreToWin, PlayerReward reward, StoryDefinitionId raceWonDialogueId)
        {
        }
    }
}