using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metaplay.Core.Player
{
    public abstract class PlayerSegmentBasicInfoSourceItemBase<TPlayerSegmentInfo> : PlayerSegmentBasicInfoSourceItemBase, IGameConfigSourceItem<PlayerSegmentId, TPlayerSegmentInfo>, IHasGameConfigKey<PlayerSegmentId>
    {
        public PlayerSegmentId SegmentId { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public List<PlayerPropertyId> PropId { get; set; }
        public List<string> PropMin { get; set; }
        public List<string> PropMax { get; set; }
        public List<PlayerSegmentId> RequireAnySegment { get; set; }
        public List<PlayerSegmentId> RequireAllSegments { get; set; }
        public PlayerSegmentId ConfigKey { get; }

        protected PlayerSegmentBasicInfoSourceItemBase()
        {
        }
    }

    public abstract class PlayerSegmentBasicInfoSourceItemBase : IMetaIntegration<PlayerSegmentBasicInfoSourceItemBase>, IMetaIntegration
    {
    }
}