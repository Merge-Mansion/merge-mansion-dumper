using Metaplay.Core.Model;
using Metaplay.Core;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class PlayerClassicRacesEventStageModel
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public ClassicRacesEventStageState State { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public EntityId? DivisionId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public MetaTime? RequestJoinTime { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private MetaTime? StartTime { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public ClassicRacesEventStageId StageId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        private MetaTime? EndTime { get; set; }
        public bool HasRaceResult { get; }

        public PlayerClassicRacesEventStageModel()
        {
        }

        public PlayerClassicRacesEventStageModel(ClassicRacesEventStageId stageId)
        {
        }
    }
}