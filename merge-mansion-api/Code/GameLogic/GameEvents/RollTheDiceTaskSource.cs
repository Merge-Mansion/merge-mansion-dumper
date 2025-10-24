using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;

namespace Code.GameLogic.GameEvents
{
    public class RollTheDiceTaskSource : IConfigItemSource<RollTheDiceTaskInfo, RollTheDiceTaskId>, IGameConfigSourceItem<RollTheDiceTaskId, RollTheDiceTaskInfo>, IHasGameConfigKey<RollTheDiceTaskId>
    {
        public RollTheDiceTaskId ConfigKey { get; set; }
        public string[] Ingredient { get; set; }
        public int[] Amount { get; set; }
        public string ReadyDishImage { get; set; }
        public string LocalizationId { get; set; }
    }
}