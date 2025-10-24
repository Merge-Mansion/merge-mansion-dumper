using GameLogic.Merge;
using GameLogic.Config.Types;
using GameLogic.Player.Items.Decay;
using GameLogic.Player.Items.Activation;
using GameLogic.Player.Items.Spawning;
using GameLogic.Player.Items.Chest;
using GameLogic.Player.Items.Boosting;
using GameLogic.Player.Items.Bubble;
using System;
using GameLogic.Player.Items.Sink;
using GameLogic.Player.Items.TimeContainer;
using GameLogic.Player.Items.Charges;
using GameLogic.Player.Items.Merging;
using GameLogic.Player.Items.Attachments;
using GameLogic.Player.Items.Fishing;
using GameLogic.Player.Items.Persistent;
using GameLogic.Player.Items.Order;
using GameLogic.Player.Items.GemMining;
using GameLogic.MergeChains;
using Metaplay.Core;
using Metaplay.Core.Math;

namespace GameLogic.Player.Items
{
    public interface IMergeItem : IBoardItem
    {
        ItemDefinition Definition { get; }

        ItemVisibility Visibility { get; }

        MetaTime CreatedAt { get; }

        DecayState DecayState { get; }

        ActivationState ActivationState { get; }

        SpawnState SpawnState { get; }

        StorageState ActivationStorageState { get; }

        StorageState SpawnStorageState { get; }

        ChestState ChestState { get; }

        BoosterState BoosterState { get; }

        BubbleState BubbleState { get; }

        int SpecialActivationAmount { get; }

        ISinkState SinkState { get; }

        ITimeContainerState TimeContainerState { get; }

        ChargesState ChargesState { get; }

        XpState ExperienceState { get; }

        ItemAttachmentsState AttachmentsState { get; }

        ItemLeaderboardState LeaderboardState { get; }

        ItemRewardsState RewardsState { get; }

        FishingRodState FishingRodState { get; }

        WeightState WeightState { get; }

        PersistentState PersistentState { get; }

        OrderParentState OrderState { get; }

        RockChunkState RockChunkState { get; }

        GemState GemState { get; }

        IItemEffectFeatures ItemActivationEffects { get; }

        bool ShowTutorialFingerOnDiscovery { get; }

        bool UseCalendarBasedCycle { get; }

        bool HasActivationVfx { get; }

        bool ActivationMiniGame { get; }

        bool LargeItem2x2 { get; }

        int ItemLevel { get; }

        bool IsChest { get; }

        bool SupportsSpawning { get; }

        bool SupportsActivation { get; }

        bool CanSpawn { get; }

        bool IsInsideBubble { get; }

        bool IsActivableOrder { get; }

        bool IsVisible { get; }

        bool IsPartiallyVisible { get; }

        bool ShowGemWeightLabel { get; }

        bool IsSink { get; }

        bool IsSinkableOrder { get; }

        int RemainingCharges { get; }

        bool IsLootable { get; }

        MetaDuration? InfiniteEnergyDuration { get; }

        MetaDuration RemainingTimeContained { get; }

        bool CanBeUnlocked { get; }

        ValueTuple<Currencies, int> UnlockValue { get; }

        bool SupportsMerge { get; }

        WeightState WeightStateMaybe { get; }

        ItemAttachmentsState AttachmentsStateMaybe { get; }

        bool HideSinkUndiscoveredItemsInHints { get; }

        MergeChainId ChainId { get; }

        MergeItem.MergeItemExtra Extra { get; }

        F32 TimeBoostMultiplier { get; }

        F32 TimeSpawnBoostMultiplier { get; }

        MetaTime? NextSpawnStorageTimestamp { get; }

        MetaDuration? RemainingDuration { get; }
    }
}