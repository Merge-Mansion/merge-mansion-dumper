using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic;

namespace Code.GameLogic.Area
{
    [MetaSerializable]
    public class LocationInfo : IGameConfigData<LocationId>, IGameConfigData, IHasGameConfigKey<LocationId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public LocationId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public LocationUIStyle UIStyle { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public LocationCameraStyle CameraStyle { get; set; }
    }
}