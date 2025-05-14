using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Metaplay.Core;
using System;
using System.Runtime.Serialization;
using Game.Cloud.Config;

namespace GameLogic.Area
{
    [MetaSerializable]
    public class MapSpotInfo : IGameConfigData<MapSpotId>, IGameConfigData, IHasGameConfigKey<MapSpotId>
    {
        public MapSpotId ConfigKey => MapSpotId;

        [MetaMember(1, (MetaMemberFlags)0)]
        private MapSpotId MapSpotId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private AreaInfoDef AreaRef { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string TitleId { get; set; }

        public MapSpotInfo()
        {
        }

        public MapSpotInfo(MapSpotId configKey, AreaId area, string titleId)
        {
        }
    }
}