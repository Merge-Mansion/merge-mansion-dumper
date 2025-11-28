using System;
using Metaplay.Core;
using GameLogic.Config;

namespace GameLogic.Player.Items.Persistent
{
    public interface IPersistentFeatures
    {
        bool HasPersistentFeatures { get; }

        bool HasItemStates { get; }

        int DecayCycles { get; }

        int ItemStates { get; }

        ItemDef ResetToItem { get; }
    }
}