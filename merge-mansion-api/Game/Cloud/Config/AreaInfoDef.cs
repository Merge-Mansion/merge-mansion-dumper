using Metaplay.Core.Model;
using GameLogic.Area;

namespace Game.Cloud.Config
{
    [MetaSerializableDerived(1)]
    public class AreaInfoDef : ConfigDefinition<AreaId, AreaInfo>
    {
        public AreaInfoDef(AreaId key)
        {
        }

        private AreaInfoDef()
        {
        }
    }
}