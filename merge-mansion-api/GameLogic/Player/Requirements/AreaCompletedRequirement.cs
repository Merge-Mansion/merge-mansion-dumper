using GameLogic.Area;
using Metaplay.Core;
using Metaplay.Core.Model;
using System.Runtime.Serialization;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(10)]
    public class AreaCompletedRequirement : PlayerRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaRef<AreaInfo> AreaRef { get; set; }

        [IgnoreDataMember]
        public AreaInfo Area { get; }

        private AreaCompletedRequirement()
        {
        }

        public AreaCompletedRequirement(AreaId id)
        {
        }
    }
}