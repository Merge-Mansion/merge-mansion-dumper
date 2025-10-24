using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic.Player.Rewards;
using System.Collections.Generic;
using System;
using Metaplay.Core.Math;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class RollTheDiceLevelInfo : IGameConfigData<RollTheDiceLevelId>, IGameConfigData, IHasGameConfigKey<RollTheDiceLevelId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public RollTheDiceLevelId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public PlayerReward Reward { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public RollTheDiceTaskId TaskId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<RollTheDiceGameDiceId> Dices { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public RollTheDiceMultiplierId MultiplierId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int DuplicatesFallbackRewardAmount { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public PlayerReward DuplicatesRefundRewardId { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public int DiffTriesMin { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public int DiffTriesMax { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public F32 DiffBumpMin { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public F32 DiffBumpMax { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public string Character { get; set; }
    }
}