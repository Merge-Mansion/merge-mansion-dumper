using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.Player
{
    [MetaImplicitMembersRange(100, 110)]
    [ModelActionExecuteFlags((ModelActionExecuteFlags)1)]
    [MetaSerializable]
    public abstract class PlayerActionBase : ModelAction<IPlayerModelBase>
    {
        public int Id { get; set; } // 0x10

        protected PlayerActionBase()
        {
        }
    }
}