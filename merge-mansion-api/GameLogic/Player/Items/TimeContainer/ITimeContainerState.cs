using Metaplay.Core;

namespace GameLogic.Player.Items.TimeContainer
{
    public interface ITimeContainerState
    {
        MetaDuration Remaining { get; }
    }
}