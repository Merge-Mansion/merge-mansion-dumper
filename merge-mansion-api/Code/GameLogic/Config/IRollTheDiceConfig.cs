using Code.GameLogic.GameEvents;
using System.Collections.Generic;

namespace Code.GameLogic.Config
{
    public interface IRollTheDiceConfig
    {
        Dictionary<CoreSupportEventMinigameId, RollTheDiceMinigameInfo> Minigames { get; }

        Dictionary<RollTheDiceLevelId, RollTheDiceLevelInfo> Levels { get; }

        Dictionary<RollTheDiceTaskId, RollTheDiceTaskInfo> Tasks { get; }

        Dictionary<RollTheDiceGameDiceId, RollTheDiceGameDice> GameDices { get; }

        Dictionary<RollTheDiceMultiplierId, RollTheDiceMultiplierInfo> Multipliers { get; }
    }
}