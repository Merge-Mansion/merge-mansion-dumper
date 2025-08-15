using Metaplay.Core.Model;
using GameLogic;
using System.Runtime.Serialization;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializableDerived(4)]
    public class CompleteTaskTrigger : IExtraSpawnTrigger
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public HotspotId? Hotspot { get; set; }

        public CompleteTaskTrigger()
        {
        }

        public CompleteTaskTrigger(HotspotId? hotspot)
        {
        }

        [IgnoreDataMember]
        public ExtraSpawnTriggerType Type { get; }
    }
}