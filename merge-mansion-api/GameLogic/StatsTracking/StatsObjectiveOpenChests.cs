using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using Analytics;

namespace GameLogic.StatsTracking
{
    [MetaSerializableDerived(8)]
    public class StatsObjectiveOpenChests : StatsObjective
    {
        [MetaMember(100, (MetaMemberFlags)0)]
        public sealed override long SnapshotAmount { get; set; }

        [MetaMember(101, (MetaMemberFlags)0)]
        public sealed override string ObjectiveId { get; set; }

        [MetaMember(102, (MetaMemberFlags)0)]
        public sealed override ObjectiveState State { get; set; }

        [MetaMember(103, (MetaMemberFlags)0)]
        public sealed override int ProgressIndex { get; set; }

        [MetaMember(104, (MetaMemberFlags)0)]
        public sealed override List<int> ObjectiveRequirements { get; set; }
        public override StatsObjectiveType ObjectiveType { get; }

        public StatsObjectiveOpenChests()
        {
        }

        public StatsObjectiveOpenChests(IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements)
        {
        }

        [MetaMember(105, (MetaMemberFlags)0)]
        public sealed override TaskType TypeTask { get; set; }

        public StatsObjectiveOpenChests(IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements, TaskType typeTask)
        {
        }
    }
}