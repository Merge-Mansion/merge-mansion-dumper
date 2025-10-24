using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class RollTheDiceTaskInfo : IGameConfigData<RollTheDiceTaskId>, IGameConfigData, IHasGameConfigKey<RollTheDiceTaskId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public RollTheDiceTaskId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string[] Ingredients { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int[] Amounts { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string DishImage { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public string LocalizationId { get; set; }
    }
}