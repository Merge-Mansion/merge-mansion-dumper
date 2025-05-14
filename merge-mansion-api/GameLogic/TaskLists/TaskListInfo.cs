using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;

namespace GameLogic.TaskLists
{
    [MetaSerializable]
    public class TaskListInfo : IGameConfigData<TaskListId>, IGameConfigData, IHasGameConfigKey<TaskListId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public TaskListId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int TaskSlots { get; set; }

        public TaskListInfo()
        {
        }

        public TaskListInfo(TaskListId configKey, int taskSlots)
        {
        }
    }
}