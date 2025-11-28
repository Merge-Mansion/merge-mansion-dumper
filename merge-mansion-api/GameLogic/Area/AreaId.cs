using Metaplay.Core;
using Metaplay.Core.Model;

namespace GameLogic.Area
{
    [MetaSerializable]
    public class AreaId : StringId<AreaId>
    {
        public static AreaId ComingSoon;
        public AreaId()
        {
        }

        public static AreaId MADDIE_MEETS_MANSION;
    }
}