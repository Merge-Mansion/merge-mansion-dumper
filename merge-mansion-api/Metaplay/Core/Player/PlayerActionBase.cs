using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.Player
{
    [MetaSerializable]
    [MetaImplicitMembersRange(101, 110)]
    [MetaBlockedMembers(new int[] { 100 })]
    [ModelActionExecuteFlags((ModelActionExecuteFlags)1)]
    public abstract class PlayerActionBase : ModelAction<IPlayerModelBase>
    {
        protected PlayerActionBase()
        {
        }
    }
}