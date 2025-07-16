using Code.GameLogic.Config;
using Metaplay.Core.Config;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents
{
    public class CoreSupportEventModeSource : IConfigItemSource<CoreSupportEventModeInfo, CoreSupportEventModeId>, IGameConfigSourceItem<CoreSupportEventModeId, CoreSupportEventModeInfo>, IHasGameConfigKey<CoreSupportEventModeId>
    {
        public CoreSupportEventModeId ConfigKey { get; set; }
        private PlayerSegmentId EnableSegmentId { get; set; }
        private PlayerSegmentId DisableSegmentId { get; set; }

        public CoreSupportEventModeSource()
        {
        }
    }
}