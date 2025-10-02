using GameLogic.Player.Items.Spawning;
using GameLogic.Player.Items.Decay;
using GameLogic.Player.Items.Merging;
using GameLogic.Player.Items.Activation;
using GameLogic.Player.Items.Chest;
using GameLogic.Player.Items.Sink;
using GameLogic.Player.Items.Bubble;
using GameLogic.Player.Items.Charges;
using GameLogic.Player.Items.Persistent;
using GameLogic.Player.Items.Order;
using GameLogic.Player.Items.GemMining;
using GameLogic.Player.Items.Fishing;
using GameLogic.Player.Items.TimeContainer;
using GameLogic.Player.Items.Collectable;
using GameLogic.Player.Items.Leaderboard;
using GameLogic.Player.Items.Boosting;
using GameLogic.Player.Items.Consumption;
using GameLogic.Player.Items.MiniEvents;
using GameLogic.Player.Items.TheGreatEscape;
using GameLogic.Player.Items.Sinkable;
using System;
using System.Collections.Generic;
using GameLogic.MergeChains;
using Metaplay.Core.Math;
using GameLogic.Player.Requirements;
using GameLogic.Player.Rewards;
using GameLogic.Player.Items.OverrideSpawnChance;
using GameLogic.Player.Director.Config;
using Metaplay.Core;
using Metaplay.Core.Model;
using Metaplay.Core.Serialization;
using GameLogic.ConfigPrefabs;
using GameLogic.Config;

namespace GameLogic.Player.Items
{
    [MetaSerializable]
    [MetaDeserializationConvertFromConcreteDerivedType(typeof(ItemDefinition))]
    public interface IItemDefinition
    {
        ISpawnFeatures SpawnFeatures { get; }

        IDecayFeatures DecayFeatures { get; }

        IMergeFeatures MergeFeatures { get; }

        IActivationFeatures ActivationFeatures { get; }

        IChestFeatures ChestFeatures { get; }

        ISinkFeatures SinkFeatures { get; }

        IBubbleFeatures BubbleFeatures { get; }

        IChargesFeatures ChargesFeatures { get; }

        IPersistentFeatures PersistentFeatures { get; }

        IOrderFeatures OrderFeatures { get; }

        IGemWeightFeatures GemWeightFeatures { get; }

        IRockChunkFeatures RockChunkFeatures { get; }

        IFishingRodFeatures FishingRodFeatures { get; }

        ICollectableFeatures CollectableFeatures { get; }

        ILeaderboardFeatures LeaderboardFeatures { get; }

        IPortalFeatures PortalFeatures { get; }

        IBoosterFeatures BoosterFeatures { get; }

        IConsumableFeatures ConsumableFeatures { get; }

        IMiniEventFeatures MiniEventFeatures { get; }

        IPrisonBadgeFeatures PrisonBadgeFeatures { get; }

        ISinkableFeatures SinkableFeatures { get; }

        IPostBoxFeatures PostBoxFeatures { get; }

        IEscapeToolFeatures EscapeToolFeatures { get; }

        IMinigameActivationFeatures MinigameActivationFeatures { get; }

        string ItemType { get; }

        bool Movable { get; }

        List<string> ConfirmableMergeResults { get; }

        int ExperienceValue { get; }

        int LevelNumber { get; }

        int ConfigKey { get; }

        string PoolTag { get; }

        string SkinName { get; }

        List<string> Tags { get; }

        bool Unsellable { get; }

        bool ShowTutorialFingerOnDiscovery { get; }

        bool HasUnlockRequirements { get; }

        string LocalizationItemKey { get; }

        string FullOverrideLocalizationItemKey { get; }

        string OverrideLocalizationItemCategory { get; }

        ItemRarity Rarity { get; }

        F64 CostInDiamonds { get; }

        F64 TimeSkipPriceGems { get; }

        F64 UnlockOnBoardPriceGems { get; }

        List<PlayerRequirement> UnlockRequirements { get; }

        List<PlayerReward> Rewards { get; }

        ITimeContainerFeatures TimeContainerFeatures { get; }

        IFramesFeatures FramesFeatures { get; }

        IOverrideSpawnChanceFeatures OverrideSpawnChanceFeatures { get; }

        IAudioFeatures AudioFeatures { get; }

        IPrisonLetterFeatures PrisonLetterFeatures { get; }

        IItemEffectFeatures ItemEffectFeatures { get; }

        List<string> AnalyticsMetaData { get; }

        List<int> CombineInfoWithItem { get; }

        List<string> SpawnEffects { get; }

        bool ShowCustomItemInfoPopupOnDiscovery { get; }

        string SinkTag { get; set; }

        int SinkPoints { get; set; }

        List<int> OverrideProductionSource { get; set; }

        IEnumerable<IDirectorAction> OnDiscovered { get; }

        ICameraFeatures CameraFeatures { get; }

        IWeightFeatures WeightFeatures { get; }

        ConfigPrefabId CustomItemInfoPopupId { get; }

        MergeChainDef MergeChainDef { get; }

        IOnFireFeatures OnFireFeatures { get; }
    }
}