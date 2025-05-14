using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1061)]
    public class PlayerRequiresFinalCardNormalTip : TypedPlayerPropertyId<bool>
    {
        public override string DisplayName { get; }

        public PlayerRequiresFinalCardNormalTip()
        {
        }
    }
}