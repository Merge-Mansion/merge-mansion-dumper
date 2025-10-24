using Metaplay.Core.Model;
using GameLogic.Player.Items.Collectable;
using Code.GameLogic.ProgressionTracks;
using System;

namespace Code.GameLogic.Player.Items.Collectable
{
    [MetaSerializableDerived(15)]
    public class ProgressionTrackCollectAction : IProgressionTrackCollectAction, IProgressCollectAction, ICollectAction
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public ProgressionTrackId TrackId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int Progress { get; set; }
    }
}