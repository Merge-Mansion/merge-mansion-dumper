using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;

namespace GameLogic.TaskLists
{
    public class TaskListInfoSource : IConfigItemSource<TaskListInfo, TaskListId>, IGameConfigSourceItem<TaskListId, TaskListInfo>, IHasGameConfigKey<TaskListId>
    {
        public TaskListId ConfigKey { get; set; }
        public int TaskSlots { get; set; }

        public TaskListInfoSource()
        {
        }
    }
}