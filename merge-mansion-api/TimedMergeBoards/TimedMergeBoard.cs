using System.Collections.Generic;
using Events;
using GameLogic.Merge;
using GameLogic.Player.Items;
using GameLogic.Player.Requirements;
using Merge;
using Metaplay.Core;
using Metaplay.Core.Config;
using Metaplay.Core.Model;
using Code.GameLogic.Config;
using Code.GameLogic.GameEvents;

namespace TimedMergeBoards
{
    [MetaSerializable]
    public class TimedMergeBoard : IGameConfigData<MergeBoardId>, IGameConfigData, IHasGameConfigKey<MergeBoardId>, IValidatable, IHasRequirements, IMergeBoardGenerator
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private MergeBoardId Id { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaDuration Duration { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private MergeBoardGeneratorId GeneratorId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private List<PlayerRequirement> PlayerRequirements { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public MetaRef<ItemDefinition> FinalItemId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public List<PlayerRequirement> CompletesRequirements { get; set; }
        public MergeBoardId ConfigKey => Id;
        public List<PlayerRequirement> Requirements { get; }
        public IEnumerable<IPlayerRequirement> CompleteRequirements { get; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> LevelInfos { get; set; }

        public TimedMergeBoard()
        {
        }

        public TimedMergeBoard(MergeBoardId id, MergeBoardGeneratorId generatorId, MetaDuration duration, MetaRef<ItemDefinition> finalItemId, List<PlayerRequirement> playerRequirements, List<PlayerRequirement> completesRequirements, List<MetaRef<EventLevelInfo>> levelInfos)
        {
        }
    }
}