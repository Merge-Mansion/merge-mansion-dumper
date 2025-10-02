using Metaplay.Core.Model;

namespace GameLogic.Player.Events.AdStampCardEvent
{
    [MetaSerializable]
    public enum AdStampCardEventNotePhase
    {
        Review = 0,
        Start = 1,
        End = 2
    }
}