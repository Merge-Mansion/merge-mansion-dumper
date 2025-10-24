using GameLogic.Player.Items.Collectable;
using Code.GameLogic.ProgressionTracks;

namespace Code.GameLogic.Player.Items.Collectable
{
    public interface IProgressionTrackCollectAction : IProgressCollectAction, ICollectAction
    {
        ProgressionTrackId TrackId { get; }
    }
}