using Metaplay.Core.Model;

namespace GameLogic
{
    [MetaSerializable]
    public enum CalendarBoardEventStatus
    {
        None = 0,
        NotStarted = 1,
        Started = 2,
        CollectReward = 3,
        Finished = 4
    }
}