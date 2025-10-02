using System;
using Code.GameLogic.GameEvents;

namespace GameLogic.Player.Items.TheGreatEscape
{
    public interface IEscapeToolFeatures
    {
        bool IsEscapeTool { get; }

        TheGreatEscapeMinigameId MinigameId { get; }
    }
}