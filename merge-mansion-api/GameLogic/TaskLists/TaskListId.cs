using Metaplay.Core.Model;
using Metaplay.Core;

namespace GameLogic.TaskLists
{
    [MetaSerializable]
    public class TaskListId : StringId<TaskListId>
    {
        public TaskListId()
        {
        }
    }
}