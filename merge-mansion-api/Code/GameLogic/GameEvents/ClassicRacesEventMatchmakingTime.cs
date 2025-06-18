using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class ClassicRacesEventMatchmakingTime : IGameConfigData<ClassicRacesEventMatchmakingTimeId>, IGameConfigData, IHasGameConfigKey<ClassicRacesEventMatchmakingTimeId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public ClassicRacesEventMatchmakingTimeId TimeMax { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaDuration Value { get; set; }
        public ClassicRacesEventMatchmakingTimeId ConfigKey { get; }

        public ClassicRacesEventMatchmakingTime()
        {
        }

        public ClassicRacesEventMatchmakingTime(ClassicRacesEventMatchmakingTimeId configKey, MetaDuration value)
        {
        }
    }
}