using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.Hotspots;
using System.Runtime.Serialization;
using GameLogic.Area;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(60)]
    public class TaskGroupCompletedRequirement : PlayerRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaRef<TaskGroupDefinition> TaskGroupRef { get; set; }

        [IgnoreDataMember]
        public TaskGroupDefinition TaskGroup { get; }

        public TaskGroupCompletedRequirement()
        {
        }

        public TaskGroupCompletedRequirement(TaskGroupId taskGroupId)
        {
        }
    }
}