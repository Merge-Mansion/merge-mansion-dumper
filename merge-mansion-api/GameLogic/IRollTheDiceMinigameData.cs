using System;
using Code.GameLogic.GameEvents;

namespace GameLogic
{
    public interface IRollTheDiceMinigameData
    {
        int RollTheDiceLevel { get; set; }

        bool HasSeenIntroMinigameInfo { get; set; }

        string CurrentRollTheDiceEventId { get; set; }

        RollTheDiceLevelId CurrentLevelId { get; set; }
    }
}