using Code.GameLogic.Config;
using GameLogic;
using Metaplay.Core.Config;

namespace Code.GameLogic.Area
{
    public class LocationSource : IConfigItemSource<LocationInfo, LocationId>, IGameConfigSourceItem<LocationId, LocationInfo>, IHasGameConfigKey<LocationId>
    {
        public LocationId ConfigKey { get; set; }
        private LocationUIStyle UIStyle { get; set; }
        private LocationCameraStyle CameraStyle { get; set; }
    }
}