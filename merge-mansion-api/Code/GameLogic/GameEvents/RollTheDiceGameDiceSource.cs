using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    public class RollTheDiceGameDiceSource : IConfigItemSource<RollTheDiceGameDice, RollTheDiceGameDiceId>, IGameConfigSourceItem<RollTheDiceGameDiceId, RollTheDiceGameDice>, IHasGameConfigKey<RollTheDiceGameDiceId>
    {
        public RollTheDiceGameDiceId ConfigKey { get; set; }
        public int Sides { get; set; }
        private List<string> FaceName { get; set; }
        private List<int> FaceWeight { get; set; }
        private List<int> FaceValue { get; set; }
        private List<string> FaceIngredient { get; set; }
        private List<string> FaceSegmentWeight { get; set; }
    }
}