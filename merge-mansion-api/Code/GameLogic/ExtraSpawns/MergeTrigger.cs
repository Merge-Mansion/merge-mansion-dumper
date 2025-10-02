using Metaplay.Core.Model;
using System.Runtime.Serialization;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializableDerived(1)]
    public class MergeTrigger : IExtraSpawnTrigger
    {
        public MergeTrigger()
        {
        }

        [IgnoreDataMember]
        public ExtraSpawnTriggerType Type { get; }
    }
}