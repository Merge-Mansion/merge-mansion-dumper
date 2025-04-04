using System;
using GameLogic.Player.Rewards;

namespace GameLogic.Player.Items.TheGreatEscape
{
    public interface IPrisonLetterFeatures
    {
        bool IsPrisonerLetter { get; }

        PlayerReward LetterReward { get; }

        PrisonerType Prisoner { get; }

        int BackupItem { get; }
    }
}