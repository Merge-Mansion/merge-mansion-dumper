using Code.GameLogic.GameEvents;
using System;

namespace GameLogic.Player.Items.Collectable
{
    public interface ICollectEventCurrencyAction : ICollectAction
    {
        EventCurrencyId EventCurrencyId { get; }

        int Amount { get; }
    }
}