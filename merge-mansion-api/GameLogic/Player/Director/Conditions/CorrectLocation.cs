using Metaplay.Core.Model;
using System;

namespace GameLogic.Player.Director.Conditions
{
    [MetaSerializableDerived(4)]
    public class CorrectLocation : IScriptedEventCondition
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private LocationId LocationId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private bool AllowBoard { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private bool AllowCutscene { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private bool AllowHotspotCompletion { get; set; }

        public CorrectLocation()
        {
        }

        public CorrectLocation(LocationId locationId, bool allowBoard, bool allowCutscene, bool allowHotspotCompletion)
        {
        }
    }
}