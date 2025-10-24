using Metaplay.Core.Config;
using Code.GameLogic.GameEvents;
using System.Collections.Generic;
using GameLogic.Player.Rewards;
using System;

namespace Code.GameLogic.ProgressionTracks
{
    public interface IProgressionTrackInfo : IGameConfigData<ProgressionTrackId>, IGameConfigData, IHasGameConfigKey<ProgressionTrackId>, ILevelEventInfo
    {
        ProgressionTrackId TrackId { get; }

        List<PlayerReward> FinalRewards { get; }

        List<string> Args { get; }
    }
}