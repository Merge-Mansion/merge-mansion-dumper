using System;
using System.Reflection;
using Code.GameLogic.GameEvents;
using GameLogic.Area;
using GameLogic.Codex;
using GameLogic.Config.Map.Characters;
using GameLogic.Decorations;
using GameLogic.Hotspots;
using GameLogic.MergeChains;
using GameLogic.Player.Items;
using GameLogic.Player.Items.Bubble;
using GameLogic.Player.Items.Merging;
using GameLogic.Story;
using Metaplay.Core.Config;
using TimedMergeBoards;
using Metaplay.Core;
using GameLogic.Social;
using GameLogic.GameFeatures;
using Player;
using GameLogic.Config.Shop;
using Code.GameLogic.FlashSales;
using GameLogic.DailyTasks;
using GameLogic.Story.Videos;
using GameLogic.Story.SlideShows;
using GameLogic.Banks;
using GameLogic.SocialMedia;
using GameLogic.Addressables;
using GameLogic.Player.ScheduledActions;
using GameLogic.Dialogue;
using Code.GameLogic.Social;
using GameLogic.Cutscenes;
using GameLogic.TieredOffers;
using System.Collections.Generic;
using System.Diagnostics;
using Metaplay.Core.Offers;
using Merge;
using Code.GameLogic.Config;
using GameLogic.Player.Items.Fishing;
using GameLogic.Seasonality;
using GameLogic.Inventory;
using Metaplay.Core.Math;
using GameLogic.Audio;
using GameLogic.Player.Rewards;
using GameLogic.Config.DecorationShop;
using Code.GameLogic.DynamicEvents;
using GameLogic.Player.Modes;
using Metaplay.Core.Player;
using Metaplay.Core.Localization;
using Metaplay.Core.InAppPurchase;
using GameLogic.EventCharacters;
using GameLogic.Player.Items.OverrideSpawnChance;
using GameLogic.Hotspots.CardStack;
using Game.Cloud.Webshop;
using GameLogic.Advertisement;
using Metaplay;
using GameLogic.DailyTasksV2;
using GameLogic.Config.EnergyModeEvent;
using GameLogic.MiniEvents;
using Code.GameLogic.GameEvents.SoloMilestone;
using Code.GameLogic.GameEvents.DailyScoop;
using GameLogic.Player.Items.Sink;
using GameLogic.Player.Items.Order;
using GameLogic.Player.Items.GemMining;
using GameLogic.ItemsInPocket;
using GameLogic.CardCollection;
using GameLogic.Fallbacks;
using GameLogic.Player;
using Code.GameLogic.Hotspots;
using GameLogic.ProgressivePacks;
using Code.GameLogic.GameEvents.CardCollectionSupportingEvent;

namespace GameLogic.Config
{
    public class SharedGameConfig : SharedGameConfigBase
    {
        [GameConfigEntry("Items", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "SequenceId -> SequenceId #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "ItemKey -> ItemKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<int, ItemDefinition> Items { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MergeChains", true, null)]
        [GameConfigEntryTransform(typeof(MergeChainSource))]
        public GameConfigLibrary<MergeChainId, MergeChainDefinition> MergeChains { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(CodexDiscoveryRewardSource))]
        [GameConfigEntry("CodexDiscoveryRewards", true, null)]
        public GameConfigLibrary<CodexDiscoveryRewardId, CodexDiscoveryRewardInfo> CodexDiscoveryRewards { get; set; }

        [GameConfigEntry("CodexCategories", true, null)]
        [GameConfigEntryTransform(typeof(CodexCategorySource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<CodexCategoryId, CodexCategoryInfo> CodexCategories { get; set; }

        [GameConfigEntry("BubbleSetups", true, null)]
        [GameConfigEntryTransform(typeof(BubblesSetupSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<BubblesSetupId, BubblesSetup> BubbleSetups { get; set; }

        [GameConfigEntryTransform(typeof(MergeRewardSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MergeRewards", true, null)]
        public GameConfigLibrary<MergeRewardId, MergeReward> XpMergeRewards { get; set; }

        [GameConfigEntry("TimedMergeBoards", true, null)]
        [GameConfigEntryTransform(typeof(TimedMergeBoardSource))]
        [GameConfigSyntaxAdapter(new string[] { "EventId -> EventId #key" }, new string[] { }, false)]
        public GameConfigLibrary<MergeBoardId, TimedMergeBoard> TimedMergeBoards { get; set; }

        [GameConfigEntry("Boards", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "BoardId -> BoardId #key" }, new string[] { }, false)]
        public GameConfigLibrary<MergeBoardId, BoardInfo> Boards { get; set; }

        [GameConfigEntryTransform(typeof(BoardEventSource))]
        [GameConfigEntry("BoardEvents", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "EventId -> EventId #key" }, new string[] { }, false)]
        public GameConfigLibrary<EventId, BoardEventInfo> BoardEvents { get; set; }

        [GameConfigEntryTransform(typeof(ShopEventConfigSourceItem))]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("ShopEvents", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ShopEventId -> ShopEventId #key" }, new string[] { }, false)]
        public GameConfigLibrary<EventId, ShopEventInfo> ShopEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "EventId -> EventId #key" }, new string[] { }, false)]
        [GameConfigEntry("CollectibleBoardEvents", true, null)]
        [GameConfigEntryTransform(typeof(CollectibleBoardEventSource))]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        public GameConfigLibrary<CollectibleBoardEventId, CollectibleBoardEventInfo> CollectibleBoardEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "EventId -> EventId #key" }, new string[] { }, false)]
        [GameConfigEntry("LeaderboardEvents", true, null)]
        [GameConfigEntryTransform(typeof(LeaderboardEventSource))]
        public GameConfigLibrary<LeaderboardEventId, LeaderboardEventInfo> LeaderboardEvents { get; set; }

        [GameConfigEntry("ProgressionEvents", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "EventId -> EventId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(ProgressionEventSource))]
        public GameConfigLibrary<ProgressionEventId, ProgressionEventInfo> ProgressionEvents { get; set; }

        [GameConfigEntryTransform(typeof(MapCharacterEventDefinitionSource))]
        [GameConfigEntry("MapCharacterEvents", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "MapCharacterEventId -> MapCharacterEventId #key" }, new string[] { }, false)]
        public GameConfigLibrary<MapCharacterEventId, MapCharacterEventDefinition> MapCharacterEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "EventCurrencyId -> EventCurrencyId #key" }, new string[] { }, false)]
        [GameConfigEntry("EventCurrencies", true, null)]
        public GameConfigLibrary<EventCurrencyId, EventCurrencyInfo> EventCurrencies { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "EventLevelId -> EventLevelId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(EventLevelInfoSource))]
        [GameConfigEntry("EventLevels", true, null)]
        public GameConfigLibrary<EventLevelId, EventLevelInfo> EventLevels { get; set; }

        [GameConfigEntry("EventLevelSets", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "SetId -> SetId #key" }, new string[] { }, false)]
        private GameConfigLibrary<EventLevelSetId, EventLevels> LevelSets { get; set; }

        [GameConfigEntry("EventTasks", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "EventTaskId -> EventTaskId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(EventTaskConfigSourceItem))]
        public GameConfigLibrary<EventTaskId, EventTaskInfo> EventTasks { get; set; }

        [GameConfigEntry("EventOffers", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "EventOfferId -> EventOfferId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(EventShopOfferSourceConfigItem))]
        public GameConfigLibrary<EventOfferId, EventOfferInfo> EventOffers { get; set; }

        [GameConfigEntry("ProgressionEventPerks", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(ProgressionEventPerkSource))]
        public GameConfigLibrary<ProgressionEventPerkId, ProgressionEventPerkInfo> ProgressionEventPerks { get; set; }

        [GameConfigEntry("EventOfferSets", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "EventOfferSetId -> EventOfferSetId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(EventOfferSetSource))]
        public GameConfigLibrary<EventOfferSetId, EventOfferSetInfo> EventOfferSets { get; set; }

        [GameConfigEntry("TieredOffers", true, null)]
        [GameConfigEntryTransform(typeof(TieredOfferSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<TieredOfferId, TieredOffer> TieredOffers { get; set; }

        [GameConfigEntry("DailyTasks", true, null)]
        [GameConfigEntryTransform(typeof(DailyTaskSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DailyTaskId, DailyTaskDefinition> DailyTasks { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("Areas", true, null)]
        public GameConfigLibrary<AreaId, AreaInfo> Areas { get; set; }

        [GameConfigEntry("HotspotDefinitions", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "HotspotId -> HotspotId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(HotspotDefinitionSource))]
        public GameConfigLibrary<HotspotId, HotspotDefinition> HotspotDefinitions { get; set; }

        [GameConfigEntry("MapSpots", true, null)]
        [GameConfigEntryTransform(typeof(MapSpotSource))]
        [GameConfigSyntaxAdapter(new string[] { "MapSpotId -> MapSpotId #key" }, new string[] { }, false)]
        public GameConfigLibrary<MapSpotId, MapSpotInfo> MapSpots { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "LevelKey -> LevelKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(PlayerLevelDataSource))]
        [GameConfigEntry("PlayerLevels", true, null)]
        public GameConfigLibrary<int, PlayerLevelData> PlayerLevels { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("InventorySlots", true, null)]
        public GameConfigLibrary<InventorySlotId, InventorySlotsConfig> InventorySlots { get; set; }

        [GameConfigEntry("LevelUpTutorialConfig", true, null)]
        [GameConfigEntryTransform(typeof(LevelUpTutorialConfigSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigId -> ConfigId #key" }, new string[] { }, false)]
        public GameConfigLibrary<LevelUpTutorialConfigId, LevelUpTutorialConfig> LevelUpTutorialConfig { get; set; }

        [GameConfigEntry("ShopItems", true, null)]
        [GameConfigEntryTransform(typeof(ShopItemInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ShopItemId -> ShopItemId #key" }, new string[] { }, false)]
        public GameConfigLibrary<ShopItemId, ShopItemInfo> ShopItems { get; set; }
        public Dictionary<FlashSaleGroupId, FlashSaleGroupDefinition> FlashSaleGroups { get; set; }

        [GameConfigEntry("ShopLayouts", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<ShopLayoutId, ShopLayout> ShopLayouts { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ShopItemId -> ShopItemId #key" }, new string[] { }, false)]
        [GameConfigEntry("DynamicPurchaseProducts", true, null)]
        [GameConfigEntryTransform(typeof(DynamicPurchaseDefinitionSource))]
        public GameConfigLibrary<ShopItemId, DynamicPurchaseDefinition> DynamicPurchaseProducts { get; set; }

        [GameConfigEntry("CurrencyBank", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntryTransform(typeof(CurrencyBankSource))]
        public GameConfigLibrary<CurrencyBankId, CurrencyBankInfo> CurrencyBanks { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "GameFeatureId -> GameFeatureId #key" }, new string[] { }, false)]
        [GameConfigEntry("GameFeatures", true, null)]
        [GameConfigEntryTransform(typeof(GameFeatureSettingSource))]
        public GameConfigLibrary<GameFeatureId, GameFeatureSetting> GameFeatures { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> Member" }, new string[] { }, false)]
        [GameConfigEntry("SharedGlobals", true, null)]
        public SharedGlobals SharedGlobals { get; set; }

        [GameConfigEntryTransform(typeof(SuppressedWarningsSource))]
        [GameConfigEntry("SuppressedWarnings", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "RuleId -> RuleId #key" }, new string[] { }, false)]
        public GameConfigLibrary<int, SuppressedBuildLogsInfo> SuppressedWarnings { get; set; }

        [GameConfigEntry("AddressablesDownloadProcesses", true, null)]
        [GameConfigEntryTransform(typeof(AddressablesDownloadProcessSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<AddressablesDownloadProcessId, AddressablesDownloadProcess> AddressablesDownloadProcesses { get; set; }

        [GameConfigEntry("ReEngagementSettings", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(ReEngagementSettingsSource))]
        public GameConfigLibrary<ReEngagementSettingsId, ReEngagementSettings> ReEngagementSettings { get; set; }

        [GameConfigEntry("FishingSettings", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> Member" }, new string[] { }, false)]
        public FishingSettings FishingSettings { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("ScheduledActions", true, null)]
        [GameConfigEntryTransform(typeof(ScheduledActionSource))]
        public GameConfigLibrary<ScheduledActionId, ScheduledActionInfo> ScheduledActions { get; set; }

        [GameConfigEntryTransform(typeof(StoryElementInfoSourceItem))]
        [GameConfigSyntaxAdapter(new string[] { "StoryDefinitionId -> StoryDefinitionId #key" }, new string[] { }, false)]
        [GameConfigEntry("StoryDefinitions", true, null)]
        public GameConfigLibrary<StoryDefinitionId, StoryElementInfo> StoryElements { get; set; }

        [GameConfigEntry("DialogItems", true, null)]
        [GameConfigEntryTransform(typeof(DialogItemInfoSourceItem))]
        [GameConfigSyntaxAdapter(new string[] { "DialogItemId -> DialogItemId #key" }, new string[] { }, false)]
        public GameConfigLibrary<DialogItemId, DialogItemInfo> DialogItems { get; set; }

        [GameConfigEntry("CollectibleDialoguesInfo", true, null)]
        [GameConfigEntryTransform(typeof(CollectibleDialoguesSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<CollectibleDialoguesInfoId, CollectibleDialoguesInfo> CollectibleDialoguesInfo { get; set; }

        [GameConfigEntryTransform(typeof(DialogueCharacterSource))]
        [GameConfigSyntaxAdapter(new string[] { "DialogCharacterType -> DialogCharacterType #key" }, new string[] { }, false)]
        [GameConfigEntry("DialogueCharacters", true, null)]
        public GameConfigLibrary<DialogCharacterType, DialogueCharacterInfo> DialogueCharacters { get; set; }

        [GameConfigEntryTransform(typeof(GarageCleanupEventSourceConfigItem))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("GarageCleanupEvents", true, null)]
        public GameConfigLibrary<GarageCleanupEventId, GarageCleanupEventInfo> GarageCleanupEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key", "RowNumber -> RowNumber #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(GarageCleanupBoardRowSource))]
        [GameConfigEntry("GarageCleanupBoardRows", true, null)]
        public GameConfigLibrary<GarageCleanupBoardRowId, GarageCleanupBoardRowInfo> GarageCleanupBoardRows { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(GarageCleanupPatternSetSource))]
        [GameConfigEntry("GarageCleanupPatternSets", true, null)]
        public GameConfigLibrary<GarageCleanupPatternSetId, GarageCleanupPatternSetInfo> GarageCleanupPatternSets { get; set; }

        [GameConfigEntry("GarageCleanupPatternRows", true, null)]
        [GameConfigEntryTransform(typeof(GarageCleanupPatternRowSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key", "RowNumber -> RowNumber #key" }, new string[] { }, false)]
        public GameConfigLibrary<GarageCleanupPatternRowId, GarageCleanupPatternRowInfo> GarageCleanupPatternRows { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(GarageCleanupRewardSource))]
        [GameConfigEntry("GarageCleanupRewards", true, null)]
        public GameConfigLibrary<GarageCleanupRewardId, GarageCleanupRewardInfo> GarageCleanupRewards { get; set; }

        [GameConfigEntryTransform(typeof(DecorationInfoSource))]
        [GameConfigEntry("Decorations", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "DecorationId -> DecorationId #key" }, new string[] { }, false)]
        public GameConfigLibrary<DecorationId, DecorationInfo> Decorations { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "SetId -> SetId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(LayeredDecorationSetSource))]
        [GameConfigEntry("LayeredDecorations", true, null)]
        public GameConfigLibrary<LayeredDecorationSetId, LayeredDecorationSetInfo> LayeredDecorations { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "AuthenticationPlatformId -> AuthenticationPlatformId #key" }, new string[] { }, false)]
        [GameConfigEntry("SocialAuthentication", true, null)]
        public GameConfigLibrary<AuthenticationPlatform, SocialAuthenticationConfig> SocialAuthentication { get; set; }

        [GameConfigEntryTransform(typeof(SocialMediaSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("SocialMedia", true, null)]
        public GameConfigLibrary<SocialMediaId, SocialMediaInfo> SocialMedia { get; set; }

        [GameConfigEntry("SocialAuthRewards", true, null)]
        [GameConfigEntryTransform(typeof(SocialAuthRewardSource))]
        [GameConfigSyntaxAdapter(new string[] { "SocialAuthRewardId -> SocialAuthRewardId #key" }, new string[] { }, false)]
        public GameConfigLibrary<SocialAuthRewardId, SocialAuthRewardInfo> SocialAuthRewards { get; set; }

        [GameConfigEntry("Videos", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(VideoSource))]
        public GameConfigLibrary<VideoId, Video> Videos { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("SlideShows", true, null)]
        [GameConfigEntryTransform(typeof(SlideShowSource))]
        public GameConfigLibrary<SlideShowId, SlideShow> SlideShows { get; set; }

        [GameConfigEntryTransform(typeof(CutsceneInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "CutsceneId -> CutsceneId #key" }, new string[] { }, false)]
        [GameConfigEntry("Cutscenes", true, null)]
        public GameConfigLibrary<CutsceneId, CutsceneInfo> Cutscenes { get; set; }

        public override void Import(GameConfigImporter importer)
        {
            // CUSTOM: Re-implement by using reflection, instead of source generating from GameConfigEntryAttribute
            var properties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var property in properties)
            {
                // Get game config attribute
                var gameConfigAttribute = property.GetCustomAttribute<GameConfigEntryAttribute>();
                if (gameConfigAttribute == null)
                    continue;
                // Create entry name
                var entryName = gameConfigAttribute.EntryName;
                if (gameConfigAttribute.MpcFormat)
                    entryName += ".mpc";
                // Check if entry exists
                if (!importer.Contains(entryName))
                {
                    if (gameConfigAttribute.RequireArchiveEntry)
                        throw new InvalidOperationException($"GameConfigEntry {entryName} does not exist.");
                    continue;
                }

                // Invoke ImportBinaryLibrary or ImportBinaryKeyValueStructure method
                if (property.PropertyType.GenericTypeArguments.Length == 2)
                {
                    var importMethod = typeof(GameConfigImporter).GetMethod(nameof(GameConfigImporter.ImportBinaryLibrary))?.MakeGenericMethod(property.PropertyType.GenericTypeArguments);
                    property.SetValue(this, importMethod?.Invoke(importer, new object[] { entryName }));
                }
                else
                {
                    var importMethod = typeof(GameConfigImporter).GetMethod(nameof(GameConfigImporter.ImportBinaryKeyValueStructure))?.MakeGenericMethod(property.PropertyType);
                    property.SetValue(this, importMethod?.Invoke(importer, new object[] { entryName, false }));
                }
            }

            // CUSTOM: Resolve MetaRef's, if toggled on
            foreach (var property in properties)
            {
                // Get game config attribute
                var gameConfigAttribute = property.GetCustomAttribute<GameConfigEntryAttribute>();
                if (gameConfigAttribute == null)
                    continue;
                // Invoke ResolveMetaRefs method
                if (gameConfigAttribute.ResolveContainedMetaRefs)
                {
                    var method = property.PropertyType.GetMethod("ResolveMetaRefs");
                    var propertyValue = property.GetValue(this);
                    if (propertyValue == null)
                        continue;
                    method?.Invoke(propertyValue, new object[] { this });
                }
            }
        }

        public Dictionary<OfferPlacementId, List<OfferPlacementId>> OfferPlacementIds { get; set; }
        public int MaxPlayerLevel { get; set; }
        public Dictionary<MergeBoardId, CollectibleBoardEventId> CollectibleBoardEventBoards { get; set; }
        public Dictionary<MergeBoardId, LeaderboardEventId> LeaderboardEventBoards { get; set; }
        public Dictionary<DialogCharacterType, HashSet<HotspotId>> HotspotIdsByDialogCharacterTypeToDiscover { get; set; }
        public Dictionary<LeaderboardEventId, HashSet<MergeChainDefinition>> MergeChainsByLeaderboardEventId { get; set; }
        public Dictionary<DialogItemId, List<DialogCharacterType>> CharactersToForceDiscoverByNonHotspotDialogItemId { get; set; }
        public Dictionary<OfferPlacementId, List<MetaOfferGroupId>> OfferGroupIdsByOfferPlacementId { get; set; }
        private IEnumerable<IValidatable> ValidatableEntries { get; }

        public SharedGameConfig()
        {
        }

        public HashSet<int> SecondaryEnergyMergeBoardPortalItems { get; set; }
        public Dictionary<CollectibleBoardEventId, MergeBoardId> FishingEventBoards { get; set; }

        [GameConfigEntry("ProgressionEventStreaks", true, null)]
        [GameConfigEntryTransform(typeof(ProgressionEventStreakRewardsSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<ProgressionEventStreakId, ProgressionEventStreakRewards> ProgressionEventStreaks { get; set; }

        [GameConfigEntryTransform(typeof(SeasonInfoSource))]
        [GameConfigEntry("Seasons", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "SeasonId -> SeasonId #key" }, new string[] { }, false)]
        public GameConfigLibrary<SeasonId, SeasonInfo> Seasons { get; set; }

        [GameConfigEntryTransform(typeof(RentableInventorySettingsSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("RentableInventorySettings", true, null)]
        public GameConfigLibrary<RentableInventorySettingsId, RentableInventorySettings> RentableInventorySettings { get; set; }

        [GameConfigEntryTransform(typeof(PetInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("PetInfos", true, null)]
        public GameConfigLibrary<PetId, PetInfo> PetInfos { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("DecorationShops", true, null)]
        [GameConfigEntryTransform(typeof(DecorationShopSource))]
        public GameConfigLibrary<DecorationShopId, DecorationShopInfo> DecorationShops { get; set; }

        [GameConfigEntryTransform(typeof(DecorationShopSetSource))]
        [GameConfigEntry("DecorationShopSets", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DecorationShopSetId, DecorationShopSetInfo> DecorationShopSets { get; set; }

        [GameConfigEntry("DecorationShopItems", true, null)]
        [GameConfigEntryTransform(typeof(DecorationShopItemSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DecorationShopItemId, DecorationShopItemInfo> DecorationShopItems { get; set; }

        [GameConfigEntryTransform(typeof(EventTaskConfigSourceItem))]
        [GameConfigSyntaxAdapter(new string[] { "EventTaskId -> EventTaskId #key" }, new string[] { }, false)]
        [GameConfigEntry("DynamicEventTasks", true, null)]
        public GameConfigLibrary<EventTaskId, EventTaskInfo> DynamicEventTasks { get; set; }

        [GameConfigEntry("DynamicEventRewards", true, null)]
        [GameConfigEntryTransform(typeof(DynamicEventRewardConfigSourceItem))]
        [GameConfigSyntaxAdapter(new string[] { "EventId -> EventId #key" }, new string[] { }, false)]
        public GameConfigLibrary<DynamicEventRewardId, DynamicEventRewardInfo> DynamicEventRewards { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DynamicEventItemInfoSourceItem))]
        [GameConfigEntry("DynamicEventItems", true, null)]
        public GameConfigLibrary<DynamicEventItemId, DynamicEventItemInfo> DynamicEventItems { get; set; }

        [GameConfigEntryTransform(typeof(DynamicEventHelperInfoSourceItem))]
        [GameConfigEntry("DynamicEventHelpers", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DynamicEventHelperId, DynamicEventHelperInfo> DynamicEventHelpers { get; set; }

        [GameConfigEntry("EnergyModes", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(EnergyModeSource))]
        public GameConfigLibrary<PlayerModeId, EnergyModeInfo> EnergyModes { get; set; }

        [GameConfigEntry("EnergyModeProgressionEventItems", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<int, EnergyModeProgressionEventItemInfo> EnergyModeProgressionEventItems { get; set; }
        public HashSet<MergeBoardId> AuxEnergyMergeBoards { get; set; }
        public List<ItemDefinition> FishItems { get; set; }
        public HashSet<int> ItemsAcceptedBySinks { get; set; }
        public Dictionary<int, IReadOnlyList<ValueTuple<ItemDefinition, F32>>> ItemProducingParents { get; set; }
        public Dictionary<HotspotId, IEnumerable<HotspotDefinition>> HotspotOpensAfterCompletion { get; set; }
        public Dictionary<MergeBoardId, EventId> BoardEventBoards { get; set; }
        public List<List<int>> ProducerVariants { get; set; }
        public Dictionary<MergeBoardId, List<IStringId>> EventsByMergeBoard { get; set; }
        public List<PortalPieceChainData> PortalPieceChains { get; set; }
        public Dictionary<DecorationShopItemId, List<PlayerSegmentId>> DecorationShopItemSegments { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "LanguageId -> LanguageId #key" }, new string[] { }, false)]
        [GameConfigEntry("Languages", true, null)]
        public GameConfigLibrary<LanguageId, LanguageInfo> Languages { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ProductId -> ProductId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(InAppProductConfigSource))]
        [GameConfigEntry("InAppProducts", true, null)]
        public GameConfigLibrary<InAppProductId, InAppProductInfo> InAppProducts { get; set; }

        [GameConfigEntryTransform(typeof(PlayerSegmentInfoSourceItem))]
        [GameConfigSyntaxAdapter(new string[] { "SegmentId -> SegmentId #key" }, new string[] { }, false)]
        [GameConfigEntry("PlayerSegments", true, null)]
        public GameConfigLibrary<PlayerSegmentId, PlayerSegmentInfo> PlayerSegments { get; set; }

        [GameConfigEntryTransform(typeof(MergeMansionOfferSourceConfigItem))]
        [GameConfigEntry("Offers", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "OfferId -> OfferId #key" }, new string[] { }, false)]
        public GameConfigLibrary<MetaOfferId, MergeMansionOfferInfo> Offers { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "OfferId -> OfferId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MergeMansionOfferSourceConfigItem))]
        [GameConfigEntry("TieredOfferItems", true, null)]
        public GameConfigLibrary<MetaOfferId, MergeMansionOfferInfo> TieredOfferItems { get; set; }

        [GameConfigEntry("OfferGroups", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "GroupId -> GroupId #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntryTransform(typeof(MergeMansionOfferGroupSourceItem))]
        public GameConfigLibrary<MetaOfferGroupId, MergeMansionOfferGroupInfo> OfferGroups { get; set; }

        [GameConfigEntry("SideBoardEvents", true, null)]
        [GameConfigEntryTransform(typeof(SideBoardEventSource))]
        [GameConfigSyntaxAdapter(new string[] { "EventId -> EventId #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        public GameConfigLibrary<SideBoardEventId, SideBoardEventInfo> SideBoardEvents { get; set; }

        [GameConfigEntryTransform(typeof(EventCharacterInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "EventCharacterId -> EventCharacterId #key" }, new string[] { }, false)]
        [GameConfigEntry("EventCharacters", true, null)]
        public GameConfigLibrary<EventCharacterId, EventCharacterInfo> EventCharacters { get; set; }
        public Dictionary<MergeBoardId, SideBoardEventId> SideBoardEventBoards { get; set; }
        public List<ItemDefinition> FishingRodItems { get; set; }
        public Dictionary<ItemDefinition, IOverrideSpawnChanceFeatures> OverrideSpawnChanceByItemDefinition { get; set; }
        public List<HotspotId> AreaUnlockHotspots { get; set; }

        [GameConfigEntryTransform(typeof(MMTrackSource))]
        [GameConfigEntry("Music_Tracks", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<string, MMTrack> Tracks { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("Music_Playlists", true, null)]
        [GameConfigEntryTransform(typeof(MMPlaylistSource))]
        public GameConfigLibrary<string, MMPlaylist> Playlists { get; set; }

        [GameConfigEntry("CardStacks", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<CardStackId, CardStackInfo> CardStacks { get; set; }

        [GameConfigEntry("WebShopSettings", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> Member" }, new string[] { }, false)]
        public WebShopSettings WebShopSettings { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(AdvertisementPlacementsSource))]
        [GameConfigEntry("AdvertisementPlacements", true, null)]
        public GameConfigLibrary<AdvertisementPlacementId, AdvertisementPlacementsInfo> AdvertisementPlacements { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("MysteryMachineEvents", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineEventSource))]
        public GameConfigLibrary<MysteryMachineEventId, MysteryMachineEventInfo> MysteryMachineEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineItemSetSource))]
        [GameConfigEntry("MysteryMachineItemSets", true, null)]
        public GameConfigLibrary<MysteryMachineItemSetId, MysteryMachineItemSetInfo> MysteryMachineItemSets { get; set; }

        [GameConfigEntry("MysteryMachineItems", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineItemSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineItemId, MysteryMachineItemInfo> MysteryMachineItems { get; set; }

        [GameConfigEntry("MysteryMachineItemScores", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineItemScoreSource))]
        public GameConfigLibrary<MysteryMachineItemScoreId, MysteryMachineItemScore> MysteryMachineItemScores { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MysteryMachineSpecialItems", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineSpecialItemSource))]
        public GameConfigLibrary<MysteryMachineSpecialItemItemId, MysteryMachineSpecialItemInfo> MysteryMachineSpecialItems { get; set; }

        [GameConfigEntry("MysteryMachineItemChainMultipliers", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineChainMultiplierSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineChainMultiplierId, MysteryMachineChainMultiplierInfo> MysteryMachineChainMultipliers { get; set; }

        [GameConfigEntry("MysteryMachineExtraItemGranting", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineExtraItemGrantingSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineExtraItemGrantingId, MysteryMachineExtraItemGrantingInfo> MysteryMachineExtraItemGranting { get; set; }

        [GameConfigEntry("MysteryMachineMultipliers", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineMultiplierSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineMultiplierId, MysteryMachineMultiplierInfo> MysteryMachineMultipliers { get; set; }

        [GameConfigEntryTransform(typeof(MysteryMachineSource))]
        [GameConfigEntry("MergeMysteryMachines", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineId, MysteryMachineInfo> MysteryMachines { get; set; }

        [GameConfigEntry("MergeMysteryMachineCurrencyItems", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineCurrencyItemSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineCurrencyItemId, MysteryMachineCurrencyItemInfo> MysteryMachineCurrencyItems { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineCurrencyItemChainSource))]
        [GameConfigEntry("MergeMysteryMachineCurrencyItemChains", true, null)]
        public GameConfigLibrary<MysteryMachineCurrencyItemChainId, MysteryMachineCurrencyItemChainInfo> MysteryMachineCurrencyItemChains { get; set; }

        [GameConfigEntryTransform(typeof(MysteryMachineProgressionEventProgressItemSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MergeMysteryMachineProgressionEventProgressItems", true, null)]
        public GameConfigLibrary<MysteryMachineProgressionEventProgressItemId, MysteryMachineProgressionEventProgressItemInfo> MysteryMachineProgressionEventProgressItems { get; set; }

        [GameConfigEntry("MergeMysteryMachineProgressionEventProgressItemChains", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineProgressionEventProgressItemChainSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineProgressionEventProgressItemChainId, MysteryMachineProgressionEventProgressItemChainInfo> MysteryMachineProgressionEventProgressItemChains { get; set; }

        [GameConfigEntry("MysteryMachineHeatLevels", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineHeatLevelSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineHeatLevelId, MysteryMachineHeatLevelInfo> MysteryMachineHeatLevels { get; set; }

        [GameConfigEntry("MysteryMachinePerks", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachinePerkSource))]
        public GameConfigLibrary<MysteryMachinePerkId, MysteryMachinePerkInfo> MysteryMachinePerks { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MysteryMachineSpecialSales", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineSpecialSaleSource))]
        public GameConfigLibrary<MysteryMachineSpecialSaleId, MysteryMachineSpecialSaleInfo> MysteryMachineSpecialSales { get; set; }

        [GameConfigEntry("MysteryMachineTasks", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineTaskSource))]
        public GameConfigLibrary<MysteryMachineTaskId, MysteryMachineTaskInfo> MysteryMachineTasks { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MysteryMachineTaskSets", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineTaskSetSource))]
        public GameConfigLibrary<MysteryMachineTaskSetId, MysteryMachineTaskSetInfo> MysteryMachineTaskSets { get; set; }

        [GameConfigEntry("MysteryMachineLevels", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineLevelSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineLevelId, MysteryMachineLevelInfo> MysteryMachineLevels { get; set; }
        public Dictionary<MergeBoardId, MysteryMachineEventId> MysteryMachineEventBoards { get; set; }

        [GameConfigEntry("ProducerInventorySlots", true, null)]
        [GameConfigEntryTransform(typeof(ProducerInventorySlotSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<ProducerInventorySlotId, ProducerInventorySlotConfig> ProducerInventorySlots { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(OfferPopupTriggerSource))]
        [GameConfigEntry("OfferPopupTriggers", true, null)]
        public GameConfigLibrary<OfferPopupTriggerId, OfferPopupTrigger> OfferPopupTriggers { get; set; }

        [GameConfigEntryTransform(typeof(LocationTravelSource))]
        [GameConfigEntry("LocationTravels", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<LocationTravelId, LocationTravelInfo> LocationTravels { get; set; }

        private Dictionary<FlashSaleGroupId, FlashSaleGroupDefinition> combinedFlashSaleGroups;
        [GameConfigEntry("FlashSales", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(FlashSaleSource))]
        public GameConfigLibrary<ShopItemId, FlashSaleDefinition> GarageFlashSales { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("EventFlashSales", true, null)]
        [GameConfigEntryTransform(typeof(FlashSaleSource))]
        public GameConfigLibrary<ShopItemId, FlashSaleDefinition> EventFlashSales { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("FlashSaleGroups", true, null)]
        [GameConfigEntryTransform(typeof(FlashSalesGroupSource))]
        public GameConfigLibrary<FlashSaleGroupId, FlashSaleGroupDefinition> GarageFlashSaleGroups { get; set; }

        [GameConfigEntry("EventFlashSaleGroups", true, null)]
        [GameConfigEntryTransform(typeof(FlashSalesGroupSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<FlashSaleGroupId, FlashSaleGroupDefinition> EventFlashSaleGroups { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(FlashSaleShopSettingsSource))]
        [GameConfigEntry("FlashSaleShopSettings", true, null)]
        public GameConfigLibrary<FlashSaleShopSettingsId, FlashSaleShopSettings> FlashSaleShopSettings { get; set; }

        [GameConfigEntryTransform(typeof(DailyTaskV2Source))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("DailyTasksV2", true, null)]
        public GameConfigLibrary<DailyTaskV2Id, DailyTaskV2Info> DailyTasksV2 { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyTasksV2CompletionRewardSource))]
        [GameConfigEntry("DailyTasksV2CompletionRewards", true, null)]
        public GameConfigLibrary<DailyTasksV2CompletionRewardId, DailyTasksV2CompletionRewardInfo> DailyTasksV2CompletionRewards { get; set; }

        [GameConfigEntryTransform(typeof(DailyTasksV2MergeChainSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("DailyTasksV2MergeChains", true, null)]
        public GameConfigLibrary<MergeChainId, DailyTasksV2MergeChainInfo> DailyTasksV2MergeChains { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> Member" }, new string[] { }, false)]
        [GameConfigEntry("DailyTasksV2Settings", true, null)]
        public DailyTasksV2Settings DailyTasksV2Settings { get; set; }
        public List<int> MysteryMachineItemIds { get; set; }

        [GameConfigEntry("EnergyModeEvents", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(EnergyModeEventSource))]
        public GameConfigLibrary<EnergyModeEventId, EnergyModeEventInfo> EnergyModeEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("MiniEvents", true, null)]
        [GameConfigEntryTransform(typeof(MiniEventConfigSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> MiniEventId #key" }, new string[] { }, false)]
        public GameConfigLibrary<MiniEventId, MiniEventInfo> MiniEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MakeYourOwnOfferSource))]
        [GameConfigEntry("MakeYourOwnOffers", true, null)]
        public GameConfigLibrary<MetaOfferId, MakeYourOwnOfferInfo> MakeYourOwnOffers { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(SoloMilestoneEventInfoSource))]
        [GameConfigEntry("SoloMilestoneEvents", true, null)]
        public GameConfigLibrary<SoloMilestoneEventId, SoloMilestoneEventInfo> SoloMilestoneEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(SoloMilestoneMilestonesInfoSource))]
        [GameConfigEntry("SoloMilestoneMilestones", true, null)]
        public GameConfigLibrary<SoloMilestoneMilestonesId, SoloMilestoneMilestonesInfo> SoloMilestoneMilestones { get; set; }

        [GameConfigEntryTransform(typeof(SoloMilestoneTokenSpawnsInfoSource))]
        [GameConfigEntry("SoloMilestoneTokenSpawns", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<SoloMilestoneTokenSpawnsId, SoloMilestoneTokenSpawnsInfo> SoloMilestoneTokenSpawns { get; set; }

        [GameConfigEntryTransform(typeof(DailyScoopMilestoneDataSource))]
        [GameConfigEntry("DailyScoopMilestones", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DailyScoopMilestoneId, DailyScoopMilestoneData> DailyScoopMilestones { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyScoopStandardObjectiveDataSource))]
        [GameConfigEntry("DailyScoopStandardObjectives", true, null)]
        public GameConfigLibrary<DailyScoopStandardObjectiveId, DailyScoopStandardObjectiveData> DailyScoopStandardObjectives { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyScoopSpecialObjectiveDataSource))]
        [GameConfigEntry("DailyScoopSpecialObjectives", true, null)]
        public GameConfigLibrary<DailyScoopSpecialObjectiveId, DailyScoopSpecialObjectiveData> DailyScoopSpecialObjectives { get; set; }

        [GameConfigEntry("DailyScoopDays", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyScoopDayDataSource))]
        public GameConfigLibrary<DailyScoopDayId, DailyScoopDayData> DailyScoopDays { get; set; }

        [GameConfigEntry("DailyScoopWeeks", true, null)]
        [GameConfigEntryTransform(typeof(DailyScoopWeekDataSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DailyScoopWeekId, DailyScoopWeekData> DailyScoopWeeks { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("DailyScoopEvents", true, null)]
        [GameConfigEntryTransform(typeof(DailyScoopEventInfoSource))]
        public GameConfigLibrary<DailyScoopEventId, DailyScoopEventInfo> DailyScoopEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(TagRewardsSource))]
        [GameConfigEntry("TagRewards", true, null)]
        public GameConfigLibrary<string, TagRewardsInfo> TagRewards { get; set; }

        [GameConfigEntryTransform(typeof(OrderRequirementsSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("OrderRequirements", true, null)]
        public GameConfigLibrary<OrderRequirementsId, OrderRequirements> OrderRequirements { get; set; }

        [GameConfigEntry("GemSettings", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> Member" }, new string[] { }, false)]
        public GemSettings GemSettings { get; set; }

        [GameConfigEntry("MapObjectGroups", true, null)]
        [GameConfigEntryTransform(typeof(MapObjectGroupInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MapObjectGroupId, MapObjectGroupInfo> MapObjectGroups { get; set; }
        public List<ItemDefinition> CutGemItems { get; set; }
        public HashSet<int> CardDeckItems { get; set; }
        public Dictionary<MergeBoardId, CollectibleBoardEventId> GemMineEventBoards { get; set; }
        public HashSet<int> CardItems { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyTaskV2BoultonLeagueSource))]
        [GameConfigEntry("DailyTasksV2BoultonLeague", true, null)]
        public GameConfigLibrary<DailyTaskV2Id, DailyTaskV2BoultonLeagueInfo> DailyTasksV2BoultonLeague { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyTaskV2BoultonLeagueUnlimitedSource))]
        [GameConfigEntry("DailyTasksV2BoultonLeagueUnlimited", true, null)]
        public GameConfigLibrary<DailyTaskV2Id, DailyTaskV2BoultonLeagueUnlimitedInfo> DailyTasksV2BoultonLeagueUnlimited { get; set; }

        [GameConfigEntry("DailyTasksV2ItemsBoultonLeague", true, null)]
        [GameConfigEntryTransform(typeof(DailyTasksV2ItemBoultonLeagueSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<ItemTypeConstant, DailyTasksV2ItemBoultonLeagueInfo> DailyTasksV2ItemsBoultonLeague { get; set; }

        [GameConfigEntry("BoultonLeagueEvents", true, null)]
        [GameConfigEntryTransform(typeof(BoultonLeagueEventSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        public GameConfigLibrary<BoultonLeagueEventId, BoultonLeagueEventInfo> BoultonLeagueEvents { get; set; }

        [GameConfigEntryTransform(typeof(BoultonLeagueStageSource))]
        [GameConfigEntry("BoultonLeagueStages", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<BoultonLeagueStageId, BoultonLeagueStageInfo> BoultonLeagueStages { get; set; }

        [GameConfigEntry("ItemsInPocket", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntryTransform(typeof(ItemInPocketInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<ItemInPocketId, ItemInPocketInfo> ItemInPocketInfos { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntryTransform(typeof(TemporaryCardCollectionEventSource))]
        [GameConfigEntry("TemporaryCardCollectionEvents", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<TemporaryCardCollectionEventId, TemporaryCardCollectionEventInfo> TemporaryCardCollectionEvents { get; set; }

        [GameConfigEntry("MysteryMachineLeaderboardConfigs", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineLeaderboardConfigSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineLeaderboardConfigId, MysteryMachineLeaderboardConfigInfo> MysteryMachineLeaderboardConfigs { get; set; }

        [GameConfigEntry("MysteryMachineLeaderboardRewards", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineLeaderboardRewardSource))]
        public GameConfigLibrary<MysteryMachineLeaderboardRewardId, MysteryMachineLeaderboardRewardInfo> MysteryMachineLeaderboardRewards { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MysteryMachineLeaderboardTopRankingRewards", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineLeaderboardTopRankingRewardSource))]
        public GameConfigLibrary<MysteryMachineLeaderboardTopRankingRewardId, MysteryMachineLeaderboardTopRankingRewardInfo> MysteryMachineLeaderboardTopRankingRewards { get; set; }

        [GameConfigEntry("MysteryMachineLeaderboardPercentileRankingRewards", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineLeaderboardPercentileRankingRewardSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineLeaderboardPercentileRankingRewardId, MysteryMachineLeaderboardPercentileRankingRewardInfo> MysteryMachineLeaderboardPercentileRankingRewards { get; set; }

        [GameConfigEntry("CardCollectionCardInfos", true, null)]
        [GameConfigEntryTransform(typeof(CardCollectionCardInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<CardCollectionCardId, CardCollectionCardInfo> CardCollectionCardInfos { get; set; }

        [GameConfigEntry("CardCollectionCardSetInfos", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(CardCollectionCardSetInfoSource))]
        public GameConfigLibrary<CardCollectionCardSetId, CardCollectionCardSetInfo> CardCollectionCardSetInfos { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(CardCollectionPackInfoSource))]
        [GameConfigEntry("CardCollectionPackInfos", true, null)]
        public GameConfigLibrary<CardCollectionPackId, CardCollectionPackInfo> CardCollectionPackInfos { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(CardCollectionCardActivationInfoSource))]
        [GameConfigEntry("CardCollection_Card_Activation", true, null)]
        public GameConfigLibrary<CardCollectionCardActivationId, CardCollectionCardActivationInfo> CardCollectionCardActivationInfos { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("CardCollection_Packs_Activation", true, null)]
        [GameConfigEntryTransform(typeof(CardCollectionPackActivationInfoSource))]
        public GameConfigLibrary<CardCollectionPackActivationId, CardCollectionPackActivationInfo> CardCollectionPackActivationInfos { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("CardCollection_HiddenRarity_Activation", true, null)]
        [GameConfigEntryTransform(typeof(CardCollectionHiddenRarityActivationInfoSource))]
        public GameConfigLibrary<CardCollectionHiddenRarityActivationId, CardCollectionHiddenRarityActivationInfo> CardCollectionHiddenRarityActivationInfos { get; set; }

        [GameConfigEntryTransform(typeof(CardCollectionSetActivationInfoSource))]
        [GameConfigEntry("CardCollection_Set_Activation", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<CardCollectionSetActivationId, CardCollectionSetActivationInfo> CardCollectionSetActivationInfos { get; set; }

        [GameConfigEntryTransform(typeof(CardCollectionBalanceInfoSource))]
        [GameConfigEntry("CardCollectionBalanceInfos", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<CardCollectionBalanceId, CardCollectionBalanceInfo> CardCollectionBalanceInfos { get; set; }

        [GameConfigEntry("CardCollection_EvidenceBoxes", true, null)]
        [GameConfigEntryTransform(typeof(CardCollectionEvidenceBoxSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<CardCollectionEvidenceBoxId, CardCollectionEvidenceBoxInfo> CardCollectionEvidenceBoxes { get; set; }

        [GameConfigEntryTransform(typeof(CardCollectionDuplicateRewardSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("CardCollection_DuplicateCardRewards", true, null)]
        public GameConfigLibrary<CardCollectionDuplicateRewardId, CardCollectionDuplicateRewardInfo> CardCollectionDuplicateCardRewards { get; set; }

        [GameConfigEntry("TaskGroups", true, null)]
        [GameConfigEntryTransform(typeof(TaskGroupDefinitionSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<TaskGroupId, TaskGroupDefinition> TaskGroups { get; set; }

        [GameConfigEntry("RewardContainers", true, null)]
        [GameConfigEntryTransform(typeof(RewardContainerSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<RewardContainerId, RewardContainerInfo> RewardContainers { get; set; }

        [GameConfigEntryTransform(typeof(MysteryMachineScreenSource))]
        [GameConfigEntry("MysteryMachineScreens", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineScreenId, MysteryMachineScreenInfo> MysteryMachineScreens { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MysteryMachineScreenMessagePacks", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineScreenMessagePackSource))]
        public GameConfigLibrary<MysteryMachineScreenMessagePackId, MysteryMachineScreenMessagePackInfo> MysteryMachineScreenMessagePacks { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineScreenMessageSource))]
        [GameConfigEntry("MysteryMachineScreenMessages", true, null)]
        public GameConfigLibrary<MysteryMachineScreenMessageId, MysteryMachineScreenMessageInfo> MysteryMachineScreenMessages { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("FallbackItems", true, null)]
        [GameConfigEntryTransform(typeof(FallbackItemInfoSource))]
        public GameConfigLibrary<FallbackItemId, FallbackItemInfo> FallbackItems { get; set; }

        [GameConfigEntryTransform(typeof(FallbackPlayerRewardInfoSource))]
        [GameConfigEntry("FallbackPlayerRewards", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<FallbackPlayerRewardId, FallbackPlayerRewardInfo> FallbackPlayerRewards { get; set; }
        public Dictionary<int, ItemInPocketInfo> ItemInPocketInfoByItemId { get; set; }
        public Dictionary<int, FallbackItemInfo> FallbackItemInfoByItemId { get; set; }
        public HashSet<IItemDefinition> ItemsAvailableOnlyDuringCardCollectionEvent { get; set; }
        public Dictionary<MysteryMachineLeaderboardConfigId, HashSet<PlayerSegmentId>> MysteryMachineLeaderboardRewardSegments { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> Member" }, new string[] { }, false)]
        [GameConfigEntry("CardCollectionSettings", true, null)]
        public CardCollectionSettings CardCollectionSettings { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(EnergySettingsConfigSource))]
        [GameConfigEntry("EnergySettings", true, null)]
        public GameConfigLibrary<EnergyType, EnergySettingsConfig> EnergySettings { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("HotspotTables", true, null)]
        public GameConfigLibrary<CustomHotspotTableId, CustomHotspotTablesInfo> CustomTables { get; set; }
        public Dictionary<int, CardCollectionPackId> CardPacksByItemId { get; set; }
        public List<TemporaryCardCollectionEventInfo> OrderedTemporaryCardCollectionEventInfos { get; set; }

        [GameConfigEntry("TheGreatEscapeMinigames", true, null)]
        [GameConfigEntryTransform(typeof(TheGreatEscapeMinigameInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<TheGreatEscapeMinigameId, TheGreatEscapeMinigameInfo> TheGreatEscapeMinigames { get; set; }
        public List<ItemDefinition> PrisonBadgeItems { get; set; }
        public List<ItemDefinition> PrisonerLetterItems { get; set; }
        public Dictionary<MergeBoardId, CollectibleBoardEventId> TheGreatEscapeEventBoards { get; set; }

        [GameConfigEntryTransform(typeof(DelayedOfferPurchaseRequirementSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("OfferPurchaseRequirements", true, null)]
        public GameConfigLibrary<MetaOfferId, DelayedOfferPurchaseRequirement> DelayedOfferPurchaseRequirements { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("ProgressionPacks", true, null)]
        [GameConfigEntryTransform(typeof(ProgressionPackSource))]
        public GameConfigLibrary<ProgressionPackId, ProgressionPack> ProgressionPacks { get; set; }

        [GameConfigEntry("ProgressionPackEvents", true, null)]
        [GameConfigEntryTransform(typeof(ProgressionPackEventSource))]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<ProgressionPackEventId, ProgressionPackEventInfo> ProgressionPackEvents { get; set; }

        [GameConfigEntryTransform(typeof(RewardUpgradableSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("RewardUpgradables", true, null)]
        public GameConfigLibrary<RewardUpgradableId, RewardUpgradableInfo> RewardUpgradables { get; set; }

        [GameConfigEntryTransform(typeof(ShortLeaderboardEventSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("ShortLeaderboardEvents", true, null)]
        public GameConfigLibrary<ShortLeaderboardEventId, ShortLeaderboardEventInfo> ShortLeaderboardEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(ShortLeaderboardEventStageSource))]
        [GameConfigEntry("ShortLeaderboardEventStages", true, null)]
        public GameConfigLibrary<ShortLeaderboardEventStageId, ShortLeaderboardEventStageInfo> ShortLeaderboardEventStages { get; set; }

        [GameConfigEntry("SharedProducerSettings", true, null)]
        [GameConfigEntryTransform(typeof(SharedProducerSettingsSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<SharedProducerSettingsId, SharedProducerSettings> SharedProducerSettings { get; set; }
        public HashSet<MergeBoardId> ShortLeaderboardEventBoards { get; set; }

        [GameConfigEntry("DigEventItemInfo", true, null)]
        [GameConfigEntryTransform(typeof(DigEventItemSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DigEventItemId, DigEventItemInfo> DigEventItemInfos { get; set; }

        [GameConfigEntryTransform(typeof(DigEventBoardsSource))]
        [GameConfigEntry("DigEventBoards", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DigEventBoardId, DigEventBoards> DigEventBoards { get; set; }

        [GameConfigEntry("DigEvent_Museum", true, null)]
        [GameConfigEntryTransform(typeof(DigEventMuseumShelfSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DigEventMuseumShelfId, DigEventMuseumShelfInfo> DigEventShelves { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("DigEventInfo", true, null)]
        [GameConfigEntryTransform(typeof(DigEventInfoSource))]
        public GameConfigLibrary<DigEventId, DigEventInfo> DigEvents { get; set; }

        [GameConfigEntry("DigEventShinyProgression", true, null)]
        [GameConfigEntryTransform(typeof(DigEventShinyProgressionSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DigEventShinyProgressionId, DigEventShinyProgression> DigEventShinyProgression { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("CardCollection_SupportingEvents", true, null)]
        [GameConfigEntryTransform(typeof(CardCollectionSupportingEventSource))]
        public GameConfigLibrary<CardCollectionSupportingEventId, CardCollectionSupportingEventInfo> CardCollectionSupportingEvents { get; set; }

        [GameConfigEntryTransform(typeof(CardCollectionSupportingEventReplacementPackSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("CardCollection_SupportingEvents_Packs", true, null)]
        public GameConfigLibrary<CardCollectionPackId, CardCollectionSupportingEventReplacementPackInfo> CardCollectionSupportingEventsReplacementPacks { get; set; }
        public Dictionary<ValueTuple<CardStars, TemporaryCardCollectionEventId>, DuplicateRewardPair> DuplicateRewards { get; set; }
        public Dictionary<MergeBoardId, CollectibleBoardEventId> DigEventMergeBoards { get; set; }

        [GameConfigEntryTransform(typeof(AreasGlobalUnlockRequirementSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("AreasGlobalUnlockRequirements", true, null)]
        public GameConfigLibrary<AreasGlobalUnlockRequirementId, AreasGlobalUnlockRequirementInfo> AreasGlobalUnlockRequirements { get; set; }
    }
}