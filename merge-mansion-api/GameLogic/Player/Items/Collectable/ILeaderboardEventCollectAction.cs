using Code.GameLogic.GameEvents;

namespace GameLogic.Player.Items.Collectable
{
    public interface ILeaderboardEventCollectAction : IProgressCollectAction, ICollectAction
    {
        LeaderboardEventInfo LeaderboardEvent { get; }
    }
}