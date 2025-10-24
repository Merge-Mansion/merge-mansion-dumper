using Code.GameLogic.GameEvents;
using GameLogic.Player.Rewards;
using System;

namespace Code.GameLogic.ProgressionTracks
{
    public interface IProgressionTrack : ILevelEventModel, IPointsEvent
    {
        ProgressionTrackId TrackId { get; }

        ProgressionTrackInfo TrackInfo { get; }

        bool IsCompleted { get; }

        bool FinalRewardClaimed { get; }
    }
}