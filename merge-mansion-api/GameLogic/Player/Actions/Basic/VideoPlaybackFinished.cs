using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.Story.Videos;

namespace GameLogic.Player.Actions.Basic
{
    [ModelAction(11055)]
    public class VideoPlaybackFinished : PlayerAction
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private MetaRef<Video> Video { get; set; }

        private VideoPlaybackFinished()
        {
        }

        public VideoPlaybackFinished(MetaRef<Video> video)
        {
        }

        [MetaMember(2, (MetaMemberFlags)0)]
        private VideoPlaybackFinished.ReasonType Reason { get; set; }

        [MetaSerializable]
        public enum ReasonType
        {
            Completed = 0,
            Skipped = 1,
            Error = 2
        }
    }
}