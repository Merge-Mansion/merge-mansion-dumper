using System;

namespace GameLogic.Player.Items
{
    public interface IItemEffectFeatures
    {
        string ActivationVfxPoolTag { get; }

        bool HasActivationVfx { get; }
    }
}