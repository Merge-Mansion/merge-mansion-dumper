using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using GameLogic.Player.Rewards;
using Metaplay.Core.Math;

namespace Code.GameLogic.GameEvents
{
    public class RollTheDiceLevelSource : IConfigItemSource<RollTheDiceLevelInfo, RollTheDiceLevelId>, IGameConfigSourceItem<RollTheDiceLevelId, RollTheDiceLevelInfo>, IHasGameConfigKey<RollTheDiceLevelId>
    {
        public RollTheDiceLevelId ConfigKey { get; set; }
        private RollTheDiceTaskId Task { get; set; }
        private string RewardType { get; set; }
        private string RewardId { get; set; }
        private string RewardAux0 { get; set; }
        private string RewardAux1 { get; set; }
        private int RewardAmount { get; set; }
        private RollTheDiceMultiplierId MultiplierId { get; set; }
        private List<RollTheDiceGameDiceId> Dices { get; set; }
        private int DuplicatesFallbackRewardAmount { get; set; }
        private PlayerReward DuplicatesRefundRewardId { get; set; }
        private int DiffTriesMin { get; set; }
        private int DiffTriesMax { get; set; }
        private F32 DiffBumpMin { get; set; }
        private F32 DiffBumpMax { get; set; }
        private string Character { get; set; }
    }
}