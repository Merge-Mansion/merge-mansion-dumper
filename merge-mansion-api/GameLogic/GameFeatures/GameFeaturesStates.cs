using Metaplay.Core.Model;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System;
using Metaplay.Core;

namespace GameLogic.GameFeatures
{
    [DefaultMember("Item")]
    [MetaSerializable]
    public class GameFeaturesStates
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private Dictionary<GameFeatureId, GameFeatureState> UnlockedFeatures { get; set; }

        [IgnoreDataMember]
        public bool Item { get; }

        public GameFeaturesStates()
        {
        }
    }
}