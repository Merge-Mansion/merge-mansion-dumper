using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1062)]
    public class PlayerRequiresFinalCardSpecialTip : TypedPlayerPropertyId<bool>
    {
        public override string DisplayName { get; }

        public PlayerRequiresFinalCardSpecialTip()
        {
        }
    }
}