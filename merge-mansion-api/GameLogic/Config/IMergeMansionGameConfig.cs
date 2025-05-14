using System.Collections.Generic;
using System;
using GameLogic.ItemsInPocket;
using GameLogic.Hotspots;
using Code.GameLogic.FlashSales;
using GameLogic.CardCollection;
using Game.Cloud.Webshop;
using GameLogic.Fallbacks;
using Metaplay.Core.InAppPurchase;
using GameLogic.Player.Items;
using GameLogic.Codex;
using Merge;
using TimedMergeBoards;
using Metaplay.Core;
using GameLogic.Social;
using GameLogic.GameFeatures;
using GameLogic.MiniEvents;
using Code.GameLogic.GameEvents;
using Player;
using GameLogic.Decorations;
using GameLogic.Story;
using GameLogic.Config.Map.Characters;
using GameLogic.Config.Shop;
using Metaplay.Core.Offers;
using GameLogic.Addressables;
using GameLogic.Player.ScheduledActions;
using GameLogic.Dialogue;
using GameLogic.EventCharacters;
using Code.GameLogic.Social;
using GameLogic.Cutscenes;
using GameLogic.TieredOffers;
using GameLogic.ProgressivePacks;
using GameLogic.Area;
using GameLogic.Player.Items.Fishing;
using GameLogic.Player.Items.GemMining;
using GameLogic.Seasonality;
using GameLogic.MergeChains;
using Code.GameLogic.GameEvents.CardCollectionSupportingEvent;
using GameLogic.Hotspots.CardStack;
using Metaplay.Core.Player;
using GameLogic.Banks;
using GameLogic.Player.Items.Merging;
using GameLogic.SocialMedia;
using GameLogic.Player.Rewards;
using GameLogic.Player.Modes;
using GameLogic.DailyTasksV2;
using Code.GameLogic.GameEvents.SoloMilestone;
using Code.GameLogic.GameEvents.DailyScoop;
using Metaplay.Core.Config;

namespace GameLogic.Config
{
    public interface IMergeMansionGameConfig
    {
        GameConfigLibrary<int, ItemInPocketInfo> ItemInPocketInfoByItemId { get; }

        SharedGlobals SharedGlobals { get; }

        GameConfigLibrary<HotspotId, IEnumerable<HotspotDefinition>> HotspotOpensAfterCompletion { get; }

        GameConfigLibrary<FlashSaleGroupId, FlashSaleGroupDefinition> FlashSaleGroups { get; }

        CardCollectionSettings CardCollectionSettings { get; }

        GameConfigLibrary<int, CardCollectionPackId> CardPacksByItemId { get; }

        WebShopSettings WebShopSettings { get; }

        GameConfigLibrary<int, FallbackItemInfo> FallbackItemInfoByItemId { get; }

        GameConfigLibrary<SharedProducerSettingsId, SharedProducerSettings> SharedProducerSettings { get; }

        GameConfigLibrary<InAppProductId, InAppProductInfo> InAppProducts { get; }

        GameConfigLibrary<int, ItemDefinition> Items { get; }

        GameConfigLibrary<CodexDiscoveryRewardId, CodexDiscoveryRewardInfo> CodexDiscoveryRewards { get; }

        GameConfigLibrary<CodexCategoryId, CodexCategoryInfo> CodexCategories { get; }

        GameConfigLibrary<ShopItemId, DynamicPurchaseDefinition> DynamicPurchaseProducts { get; }

        GameConfigLibrary<MergeBoardId, TimedMergeBoard> TimedMergeBoards { get; }

        GameConfigLibrary<AuthenticationPlatform, SocialAuthenticationConfig> SocialAuthentication { get; }

        GameConfigLibrary<GameFeatureId, GameFeatureSetting> GameFeatures { get; }

        GameConfigLibrary<MiniEventId, MiniEventInfo> MiniEvents { get; }

        GameConfigLibrary<MergeBoardId, BoardInfo> Boards { get; }

        GameConfigLibrary<EventId, BoardEventInfo> BoardEvents { get; }

        GameConfigLibrary<EventId, ShopEventInfo> ShopEvents { get; }

        GameConfigLibrary<EventCurrencyId, EventCurrencyInfo> EventCurrencies { get; }

        GameConfigLibrary<EventLevelId, EventLevelInfo> EventLevels { get; }

        GameConfigLibrary<EventLevelSetId, EventLevels> LevelSets { get; }

        GameConfigLibrary<EventTaskId, EventTaskInfo> EventTasks { get; }

        GameConfigLibrary<EventOfferId, EventOfferInfo> EventOffers { get; }

        GameConfigLibrary<int, PlayerLevelData> PlayerLevels { get; }

        GameConfigLibrary<HotspotId, HotspotDefinition> HotspotDefinitions { get; }

        GameConfigLibrary<DecorationId, DecorationInfo> Decorations { get; }

        GameConfigLibrary<StoryDefinitionId, StoryElementInfo> StoryElements { get; }

        GameConfigLibrary<DialogItemId, DialogItemInfo> DialogItems { get; }

        GameConfigLibrary<MapCharacterEventId, MapCharacterEventDefinition> MapCharacterEvents { get; }

        GameConfigLibrary<ShopItemId, ShopItemInfo> ShopItems { get; }

        GameConfigLibrary<ShopItemId, FlashSaleDefinition> GarageFlashSales { get; }

        GameConfigLibrary<ShopItemId, FlashSaleDefinition> EventFlashSales { get; }

        GameConfigLibrary<FlashSaleGroupId, FlashSaleGroupDefinition> GarageFlashSaleGroups { get; }

        GameConfigLibrary<FlashSaleGroupId, FlashSaleGroupDefinition> EventFlashSaleGroups { get; }

        GameConfigLibrary<DigEventItemId, DigEventItemInfo> DigEventItemInfos { get; }

        GameConfigLibrary<DigEventBoardId, DigEventBoards> DigEventBoards { get; }

        GameConfigLibrary<DigEventMuseumShelfId, DigEventMuseumShelfInfo> DigEventShelves { get; }

        GameConfigLibrary<DigEventId, DigEventInfo> DigEvents { get; }

        GameConfigLibrary<DigEventShinyProgressionId, DigEventShinyProgression> DigEventShinyProgression { get; }

        GameConfigLibrary<GarageCleanupEventId, GarageCleanupEventInfo> GarageCleanupEvents { get; }

        GameConfigLibrary<GarageCleanupBoardRowId, GarageCleanupBoardRowInfo> GarageCleanupBoardRows { get; }

        GameConfigLibrary<GarageCleanupPatternSetId, GarageCleanupPatternSetInfo> GarageCleanupPatternSets { get; }

        GameConfigLibrary<GarageCleanupPatternRowId, GarageCleanupPatternRowInfo> GarageCleanupPatternRows { get; }

        GameConfigLibrary<GarageCleanupRewardId, GarageCleanupRewardInfo> GarageCleanupRewards { get; }

        GameConfigLibrary<InventorySlotId, InventorySlotsConfig> InventorySlots { get; }

        GameConfigLibrary<ProducerInventorySlotId, ProducerInventorySlotConfig> ProducerInventorySlots { get; }

        GameConfigLibrary<FlashSaleShopSettingsId, FlashSaleShopSettings> FlashSaleShopSettings { get; }

        GameConfigLibrary<ShopLayoutId, ShopLayout> ShopLayouts { get; }

        GameConfigLibrary<int, SuppressedBuildLogsInfo> SuppressedWarnings { get; }

        GameConfigLibrary<EventOfferSetId, EventOfferSetInfo> EventOfferSets { get; }

        GameConfigLibrary<OfferPopupTriggerId, OfferPopupTrigger> OfferPopupTriggers { get; }

        GameConfigLibrary<MetaOfferId, DelayedOfferPurchaseRequirement> DelayedOfferPurchaseRequirements { get; }

        GameConfigLibrary<AddressablesDownloadProcessId, AddressablesDownloadProcess> AddressablesDownloadProcesses { get; }

        GameConfigLibrary<CollectibleDialoguesInfoId, CollectibleDialoguesInfo> CollectibleDialoguesInfo { get; }

        GameConfigLibrary<LevelUpTutorialConfigId, LevelUpTutorialConfig> LevelUpTutorialConfig { get; }

        GameConfigLibrary<ScheduledActionId, ScheduledActionInfo> ScheduledActions { get; }

        GameConfigLibrary<CollectibleBoardEventId, CollectibleBoardEventInfo> CollectibleBoardEvents { get; }

        GameConfigLibrary<LeaderboardEventId, LeaderboardEventInfo> LeaderboardEvents { get; }

        GameConfigLibrary<SideBoardEventId, SideBoardEventInfo> SideBoardEvents { get; }

        GameConfigLibrary<BoultonLeagueEventId, BoultonLeagueEventInfo> BoultonLeagueEvents { get; }

        GameConfigLibrary<BoultonLeagueStageId, BoultonLeagueStageInfo> BoultonLeagueStages { get; }

        GameConfigLibrary<DialogCharacterType, DialogueCharacterInfo> DialogueCharacters { get; }

        GameConfigLibrary<EventCharacterId, EventCharacterInfo> EventCharacters { get; }

        GameConfigLibrary<SocialAuthRewardId, SocialAuthRewardInfo> SocialAuthRewards { get; }

        GameConfigLibrary<ReEngagementSettingsId, ReEngagementSettings> ReEngagementSettings { get; }

        GameConfigLibrary<CutsceneId, CutsceneInfo> Cutscenes { get; }

        GameConfigLibrary<LayeredDecorationSetId, LayeredDecorationSetInfo> LayeredDecorations { get; }

        GameConfigLibrary<TieredOfferId, TieredOffer> TieredOffers { get; }

        GameConfigLibrary<ProgressionPackId, ProgressionPack> ProgressionPacks { get; }

        GameConfigLibrary<MetaOfferId, MakeYourOwnOfferInfo> MakeYourOwnOffers { get; }

        GameConfigLibrary<MapSpotId, MapSpotInfo> MapSpots { get; }

        FishingSettings FishingSettings { get; }

        GemSettings GemSettings { get; }

        GameConfigLibrary<ProgressionEventStreakId, ProgressionEventStreakRewards> ProgressionEventStreaks { get; }

        GameConfigLibrary<SeasonId, SeasonInfo> Seasons { get; }

        GameConfigLibrary<MergeChainId, MergeChainDefinition> MergeChains { get; }

        GameConfigLibrary<CardCollectionCardId, CardCollectionCardInfo> CardCollectionCardInfos { get; }

        GameConfigLibrary<CardCollectionCardSetId, CardCollectionCardSetInfo> CardCollectionCardSetInfos { get; }

        GameConfigLibrary<CardCollectionPackId, CardCollectionPackInfo> CardCollectionPackInfos { get; }

        GameConfigLibrary<CardCollectionCardActivationId, CardCollectionCardActivationInfo> CardCollectionCardActivationInfos { get; }

        GameConfigLibrary<CardCollectionPackActivationId, CardCollectionPackActivationInfo> CardCollectionPackActivationInfos { get; }

        GameConfigLibrary<CardCollectionHiddenRarityActivationId, CardCollectionHiddenRarityActivationInfo> CardCollectionHiddenRarityActivationInfos { get; }

        GameConfigLibrary<CardCollectionSetActivationId, CardCollectionSetActivationInfo> CardCollectionSetActivationInfos { get; }

        GameConfigLibrary<CardCollectionBalanceId, CardCollectionBalanceInfo> CardCollectionBalanceInfos { get; }

        GameConfigLibrary<CardCollectionEvidenceBoxId, CardCollectionEvidenceBoxInfo> CardCollectionEvidenceBoxes { get; }

        GameConfigLibrary<CardCollectionDuplicateRewardId, CardCollectionDuplicateRewardInfo> CardCollectionDuplicateCardRewards { get; }

        GameConfigLibrary<CardCollectionSupportingEventId, CardCollectionSupportingEventInfo> CardCollectionSupportingEvents { get; }

        GameConfigLibrary<CardCollectionPackId, CardCollectionSupportingEventReplacementPackInfo> CardCollectionSupportingEventsReplacementPacks { get; }

        GameConfigLibrary<CardStackId, CardStackInfo> CardStacks { get; }

        GameConfigLibrary<ProgressionEventId, ProgressionEventInfo> ProgressionEvents { get; }

        GameConfigLibrary<MetaOfferGroupId, MergeMansionOfferGroupInfo> OfferGroups { get; }

        GameConfigLibrary<PlayerSegmentId, PlayerSegmentInfo> PlayerSegments { get; }

        GameConfigLibrary<FallbackPlayerRewardId, FallbackPlayerRewardInfo> FallbackPlayerRewards { get; }

        GameConfigLibrary<MetaOfferId, MergeMansionOfferInfo> Offers { get; }

        GameConfigLibrary<TemporaryCardCollectionEventId, TemporaryCardCollectionEventInfo> TemporaryCardCollectionEvents { get; }

        GameConfigLibrary<ShortLeaderboardEventId, ShortLeaderboardEventInfo> ShortLeaderboardEvents { get; }

        GameConfigLibrary<CurrencyBankId, CurrencyBankInfo> CurrencyBanks { get; }

        GameConfigLibrary<AreaId, AreaInfo> Areas { get; }

        GameConfigLibrary<MergeRewardId, MergeReward> XpMergeRewards { get; }

        GameConfigLibrary<SocialMediaId, SocialMediaInfo> SocialMedia { get; }

        GameConfigLibrary<RewardContainerId, RewardContainerInfo> RewardContainers { get; }

        GameConfigLibrary<MysteryMachineId, MysteryMachineInfo> MysteryMachines { get; }

        GameConfigLibrary<int, EnergyModeProgressionEventItemInfo> EnergyModeProgressionEventItems { get; }

        GameConfigLibrary<MysteryMachineEventId, MysteryMachineEventInfo> MysteryMachineEvents { get; }

        GameConfigLibrary<PlayerModeId, EnergyModeInfo> EnergyModes { get; }

        GameConfigLibrary<MergeChainId, DailyTasksV2MergeChainInfo> DailyTasksV2MergeChains { get; }

        GameConfigLibrary<MysteryMachineLeaderboardConfigId, MysteryMachineLeaderboardConfigInfo> MysteryMachineLeaderboardConfigs { get; }

        GameConfigLibrary<PetId, PetInfo> PetInfos { get; }

        GameConfigLibrary<LocationTravelId, LocationTravelInfo> LocationTravels { get; }

        GameConfigLibrary<SoloMilestoneEventId, SoloMilestoneEventInfo> SoloMilestoneEvents { get; }

        GameConfigLibrary<DailyScoopEventId, DailyScoopEventInfo> DailyScoopEvents { get; }
    }
}