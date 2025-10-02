using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using System;

namespace GameLogic.MixABooster
{
    [MetaSerializableDerived(23)]
    [MetaActivableSet("MixABoosterEvent", false)]
    public class PlayerMixABoosterEventsModel : MetaActivableSet<MixABoosterEventId, MixABoosterEventInfo, MixABoosterEventModel>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public bool PurchaseFTUENoted { get; set; }

        public PlayerMixABoosterEventsModel()
        {
        }
    }
}