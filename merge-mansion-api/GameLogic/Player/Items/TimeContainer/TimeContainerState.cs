using Metaplay.Core.Model;
using Metaplay.Core;

namespace GameLogic.Player.Items.TimeContainer
{
    [MetaSerializable]
    public class TimeContainerState : IWritableTimeContainerState, ITimeContainerState
    {
        private static TimeContainerState empty;
        public MetaDuration Remaining { get; set; }

        public TimeContainerState()
        {
        }
    }
}