using Metaplay.Core;
using System;

namespace Game.Logic
{
    public class TaskGroupCompletedEvent : CopyableEvent<TaskGroupCompletedEvent, string>
    {
        public TaskGroupCompletedEvent()
        {
        }
    }
}