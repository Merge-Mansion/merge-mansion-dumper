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

        [GameConfigEntryTransform(typeof(BubblesSetupSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("BubbleSetups", true, null)]
        public GameConfigLibrary<BubblesSetupId, BubblesSetup> BubbleSetups { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MergeRewards", true, null)]
        [GameConfigEntryTransform(typeof(MergeRewardSource))]
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
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("CollectibleBoardEvents", true, null)]
        [GameConfigEntryTransform(typeof(CollectibleBoardEventSource))]
        public GameConfigLibrary<CollectibleBoardEventId, CollectibleBoardEventInfo> CollectibleBoardEvents { get; set; }

        [GameConfigEntry("LeaderboardEvents", true, null)]
        [GameConfigEntryTransform(typeof(LeaderboardEventSource))]
        [GameConfigSyntaxAdapter(new string[] { "EventId -> EventId #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        public GameConfigLibrary<LeaderboardEventId, LeaderboardEventInfo> LeaderboardEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "EventId -> EventId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(ProgressionEventSource))]
        [GameConfigEntry("ProgressionEvents", true, null)]
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
        [GameConfigEntryTransform(typeof(ProgressionEventPerkSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<ProgressionEventPerkId, ProgressionEventPerkInfo> ProgressionEventPerks { get; set; }

        [GameConfigEntryTransform(typeof(EventOfferSetSource))]
        [GameConfigEntry("EventOfferSets", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "EventOfferSetId -> EventOfferSetId #key" }, new string[] { }, false)]
        public GameConfigLibrary<EventOfferSetId, EventOfferSetInfo> EventOfferSets { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(TieredOfferSource))]
        [GameConfigEntry("TieredOffers", true, null)]
        public GameConfigLibrary<TieredOfferId, TieredOffer> TieredOffers { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("DailyTasks", true, null)]
        [GameConfigEntryTransform(typeof(DailyTaskSource))]
        public GameConfigLibrary<DailyTaskId, DailyTaskDefinition> DailyTasks { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("Areas", true, null)]
        public GameConfigLibrary<AreaId, AreaInfo> Areas { get; set; }

        [GameConfigEntry("HotspotDefinitions", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "HotspotId -> HotspotId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(HotspotDefinitionSource))]
        public GameConfigLibrary<HotspotId, HotspotDefinition> HotspotDefinitions { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "MapSpotId -> MapSpotId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MapSpotSource))]
        [GameConfigEntry("MapSpots", true, null)]
        public GameConfigLibrary<MapSpotId, MapSpotInfo> MapSpots { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "LevelKey -> LevelKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(PlayerLevelDataSource))]
        [GameConfigEntry("PlayerLevels", true, null)]
        public GameConfigLibrary<int, PlayerLevelData> PlayerLevels { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("InventorySlots", true, null)]
        public GameConfigLibrary<InventorySlotId, InventorySlotsConfig> InventorySlots { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigId -> ConfigId #key" }, new string[] { }, false)]
        [GameConfigEntry("LevelUpTutorialConfig", true, null)]
        [GameConfigEntryTransform(typeof(LevelUpTutorialConfigSource))]
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

        [GameConfigSyntaxAdapter(new string[] { "RuleId -> RuleId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(SuppressedWarningsSource))]
        [GameConfigEntry("SuppressedWarnings", true, null)]
        public GameConfigLibrary<int, SuppressedBuildLogsInfo> SuppressedWarnings { get; set; }

        [GameConfigEntryTransform(typeof(AddressablesDownloadProcessSource))]
        [GameConfigEntry("AddressablesDownloadProcesses", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<AddressablesDownloadProcessId, AddressablesDownloadProcess> AddressablesDownloadProcesses { get; set; }

        [GameConfigEntryTransform(typeof(ReEngagementSettingsSource))]
        [GameConfigEntry("ReEngagementSettings", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<ReEngagementSettingsId, ReEngagementSettings> ReEngagementSettings { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> Member" }, new string[] { }, false)]
        [GameConfigEntry("FishingSettings", true, null)]
        public FishingSettings FishingSettings { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntryTransform(typeof(ScheduledActionSource))]
        [GameConfigEntry("ScheduledActions", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<ScheduledActionId, ScheduledActionInfo> ScheduledActions { get; set; }

        [GameConfigEntryTransform(typeof(StoryElementInfoSourceItem))]
        [GameConfigSyntaxAdapter(new string[] { "StoryDefinitionId -> StoryDefinitionId #key" }, new string[] { }, false)]
        [GameConfigEntry("StoryDefinitions", true, null)]
        public GameConfigLibrary<StoryDefinitionId, StoryElementInfo> StoryElements { get; set; }

        [GameConfigEntry("DialogItems", true, null)]
        [GameConfigEntryTransform(typeof(DialogItemInfoSourceItem))]
        [GameConfigSyntaxAdapter(new string[] { "DialogItemId -> DialogItemId #key" }, new string[] { }, false)]
        public GameConfigLibrary<DialogItemId, DialogItemInfo> DialogItems { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("CollectibleDialoguesInfo", true, null)]
        [GameConfigEntryTransform(typeof(CollectibleDialoguesSource))]
        public GameConfigLibrary<CollectibleDialoguesInfoId, CollectibleDialoguesInfo> CollectibleDialoguesInfo { get; set; }

        [GameConfigEntry("DialogueCharacters", true, null)]
        [GameConfigEntryTransform(typeof(DialogueCharacterSource))]
        [GameConfigSyntaxAdapter(new string[] { "DialogCharacterType -> DialogCharacterType #key" }, new string[] { }, false)]
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

        [GameConfigEntry("LayeredDecorations", true, null)]
        [GameConfigEntryTransform(typeof(LayeredDecorationSetSource))]
        [GameConfigSyntaxAdapter(new string[] { "SetId -> SetId #key" }, new string[] { }, false)]
        public GameConfigLibrary<LayeredDecorationSetId, LayeredDecorationSetInfo> LayeredDecorations { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "AuthenticationPlatformId -> AuthenticationPlatformId #key" }, new string[] { }, false)]
        [GameConfigEntry("SocialAuthentication", true, null)]
        public GameConfigLibrary<AuthenticationPlatform, SocialAuthenticationConfig> SocialAuthentication { get; set; }

        [GameConfigEntry("SocialMedia", true, null)]
        [GameConfigEntryTransform(typeof(SocialMediaSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<SocialMediaId, SocialMediaInfo> SocialMedia { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "SocialAuthRewardId -> SocialAuthRewardId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(SocialAuthRewardSource))]
        [GameConfigEntry("SocialAuthRewards", true, null)]
        public GameConfigLibrary<SocialAuthRewardId, SocialAuthRewardInfo> SocialAuthRewards { get; set; }

        [GameConfigEntry("Videos", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(VideoSource))]
        public GameConfigLibrary<VideoId, Video> Videos { get; set; }

        [GameConfigEntryTransform(typeof(SlideShowSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("SlideShows", true, null)]
        public GameConfigLibrary<SlideShowId, SlideShow> SlideShows { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "CutsceneId -> CutsceneId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(CutsceneInfoSource))]
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

        [GameConfigEntry("RentableInventorySettings", true, null)]
        [GameConfigEntryTransform(typeof(RentableInventorySettingsSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<RentableInventorySettingsId, RentableInventorySettings> RentableInventorySettings { get; set; }

        [GameConfigEntry("PetInfos", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(PetInfoSource))]
        public GameConfigLibrary<PetId, PetInfo> PetInfos { get; set; }

        [GameConfigEntry("DecorationShops", true, null)]
        [GameConfigEntryTransform(typeof(DecorationShopSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        public GameConfigLibrary<DecorationShopId, DecorationShopInfo> DecorationShops { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("DecorationShopSets", true, null)]
        [GameConfigEntryTransform(typeof(DecorationShopSetSource))]
        public GameConfigLibrary<DecorationShopSetId, DecorationShopSetInfo> DecorationShopSets { get; set; }

        [GameConfigEntry("DecorationShopItems", true, null)]
        [GameConfigEntryTransform(typeof(DecorationShopItemSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DecorationShopItemId, DecorationShopItemInfo> DecorationShopItems { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "EventTaskId -> EventTaskId #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(EventTaskConfigSourceItem))]
        [GameConfigEntry("DynamicEventTasks", true, null)]
        public GameConfigLibrary<EventTaskId, EventTaskInfo> DynamicEventTasks { get; set; }

        [GameConfigEntry("DynamicEventRewards", true, null)]
        [GameConfigEntryTransform(typeof(DynamicEventRewardConfigSourceItem))]
        [GameConfigSyntaxAdapter(new string[] { "EventId -> EventId #key" }, new string[] { }, false)]
        public GameConfigLibrary<DynamicEventRewardId, DynamicEventRewardInfo> DynamicEventRewards { get; set; }

        [GameConfigEntry("DynamicEventItems", true, null)]
        [GameConfigEntryTransform(typeof(DynamicEventItemInfoSourceItem))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DynamicEventItemId, DynamicEventItemInfo> DynamicEventItems { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DynamicEventHelperInfoSourceItem))]
        [GameConfigEntry("DynamicEventHelpers", true, null)]
        public GameConfigLibrary<DynamicEventHelperId, DynamicEventHelperInfo> DynamicEventHelpers { get; set; }

        [GameConfigEntryTransform(typeof(EnergyModeSource))]
        [GameConfigEntry("EnergyModes", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<PlayerModeId, EnergyModeInfo> EnergyModes { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("EnergyModeProgressionEventItems", true, null)]
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

        [GameConfigEntryTransform(typeof(SideBoardEventSource))]
        [GameConfigEntry("SideBoardEvents", true, null)]
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

        [GameConfigEntry("Music_Tracks", true, null)]
        [GameConfigEntryTransform(typeof(MMTrackSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<string, MMTrack> Tracks { get; set; }

        [GameConfigEntry("Music_Playlists", true, null)]
        [GameConfigEntryTransform(typeof(MMPlaylistSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<string, MMPlaylist> Playlists { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("CardStacks", true, null)]
        public GameConfigLibrary<CardStackId, CardStackInfo> CardStacks { get; set; }

        [GameConfigEntry("WebShopSettings", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> Member" }, new string[] { }, false)]
        public WebShopSettings WebShopSettings { get; set; }

        [GameConfigEntry("AdvertisementPlacements", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(AdvertisementPlacementsSource))]
        public GameConfigLibrary<AdvertisementPlacementId, AdvertisementPlacementsInfo> AdvertisementPlacements { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("MysteryMachineEvents", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineEventSource))]
        public GameConfigLibrary<MysteryMachineEventId, MysteryMachineEventInfo> MysteryMachineEvents { get; set; }

        [GameConfigEntry("MysteryMachineItemSets", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineItemSetSource))]
        public GameConfigLibrary<MysteryMachineItemSetId, MysteryMachineItemSetInfo> MysteryMachineItemSets { get; set; }

        [GameConfigEntry("MysteryMachineItems", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineItemSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineItemId, MysteryMachineItemInfo> MysteryMachineItems { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineItemScoreSource))]
        [GameConfigEntry("MysteryMachineItemScores", true, null)]
        public GameConfigLibrary<MysteryMachineItemScoreId, MysteryMachineItemScore> MysteryMachineItemScores { get; set; }

        [GameConfigEntry("MysteryMachineSpecialItems", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineSpecialItemSource))]
        public GameConfigLibrary<MysteryMachineSpecialItemItemId, MysteryMachineSpecialItemInfo> MysteryMachineSpecialItems { get; set; }

        [GameConfigEntry("MysteryMachineItemChainMultipliers", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineChainMultiplierSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineChainMultiplierId, MysteryMachineChainMultiplierInfo> MysteryMachineChainMultipliers { get; set; }

        [GameConfigEntryTransform(typeof(MysteryMachineExtraItemGrantingSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MysteryMachineExtraItemGranting", true, null)]
        public GameConfigLibrary<MysteryMachineExtraItemGrantingId, MysteryMachineExtraItemGrantingInfo> MysteryMachineExtraItemGranting { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineMultiplierSource))]
        [GameConfigEntry("MysteryMachineMultipliers", true, null)]
        public GameConfigLibrary<MysteryMachineMultiplierId, MysteryMachineMultiplierInfo> MysteryMachineMultipliers { get; set; }

        [GameConfigEntry("MergeMysteryMachines", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineId, MysteryMachineInfo> MysteryMachines { get; set; }

        [GameConfigEntry("MergeMysteryMachineCurrencyItems", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineCurrencyItemSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineCurrencyItemId, MysteryMachineCurrencyItemInfo> MysteryMachineCurrencyItems { get; set; }

        [GameConfigEntryTransform(typeof(MysteryMachineCurrencyItemChainSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MergeMysteryMachineCurrencyItemChains", true, null)]
        public GameConfigLibrary<MysteryMachineCurrencyItemChainId, MysteryMachineCurrencyItemChainInfo> MysteryMachineCurrencyItemChains { get; set; }

        [GameConfigEntry("MergeMysteryMachineProgressionEventProgressItems", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineProgressionEventProgressItemSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineProgressionEventProgressItemId, MysteryMachineProgressionEventProgressItemInfo> MysteryMachineProgressionEventProgressItems { get; set; }

        [GameConfigEntry("MergeMysteryMachineProgressionEventProgressItemChains", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineProgressionEventProgressItemChainSource))]
        public GameConfigLibrary<MysteryMachineProgressionEventProgressItemChainId, MysteryMachineProgressionEventProgressItemChainInfo> MysteryMachineProgressionEventProgressItemChains { get; set; }

        [GameConfigEntry("MysteryMachineHeatLevels", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineHeatLevelSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineHeatLevelId, MysteryMachineHeatLevelInfo> MysteryMachineHeatLevels { get; set; }

        [GameConfigEntryTransform(typeof(MysteryMachinePerkSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MysteryMachinePerks", true, null)]
        public GameConfigLibrary<MysteryMachinePerkId, MysteryMachinePerkInfo> MysteryMachinePerks { get; set; }

        [GameConfigEntryTransform(typeof(MysteryMachineSpecialSaleSource))]
        [GameConfigEntry("MysteryMachineSpecialSales", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineSpecialSaleId, MysteryMachineSpecialSaleInfo> MysteryMachineSpecialSales { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineTaskSource))]
        [GameConfigEntry("MysteryMachineTasks", true, null)]
        public GameConfigLibrary<MysteryMachineTaskId, MysteryMachineTaskInfo> MysteryMachineTasks { get; set; }

        [GameConfigEntry("MysteryMachineTaskSets", true, null)]
        [GameConfigEntryTransform(typeof(MysteryMachineTaskSetSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineTaskSetId, MysteryMachineTaskSetInfo> MysteryMachineTaskSets { get; set; }

        [GameConfigEntryTransform(typeof(MysteryMachineLevelSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MysteryMachineLevels", true, null)]
        public GameConfigLibrary<MysteryMachineLevelId, MysteryMachineLevelInfo> MysteryMachineLevels { get; set; }
        public Dictionary<MergeBoardId, MysteryMachineEventId> MysteryMachineEventBoards { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(ProducerInventorySlotSource))]
        [GameConfigEntry("ProducerInventorySlots", true, null)]
        public GameConfigLibrary<ProducerInventorySlotId, ProducerInventorySlotConfig> ProducerInventorySlots { get; set; }

        [GameConfigEntryTransform(typeof(OfferPopupTriggerSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("OfferPopupTriggers", true, null)]
        public GameConfigLibrary<OfferPopupTriggerId, OfferPopupTrigger> OfferPopupTriggers { get; set; }

        [GameConfigEntry("LocationTravels", true, null)]
        [GameConfigEntryTransform(typeof(LocationTravelSource))]
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

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyTaskV2Source))]
        [GameConfigEntry("DailyTasksV2", true, null)]
        public GameConfigLibrary<DailyTaskV2Id, DailyTaskV2Info> DailyTasksV2 { get; set; }

        [GameConfigEntry("DailyTasksV2CompletionRewards", true, null)]
        [GameConfigEntryTransform(typeof(DailyTasksV2CompletionRewardSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DailyTasksV2CompletionRewardId, DailyTasksV2CompletionRewardInfo> DailyTasksV2CompletionRewards { get; set; }

        [GameConfigEntryTransform(typeof(DailyTasksV2MergeChainSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("DailyTasksV2MergeChains", true, null)]
        public GameConfigLibrary<MergeChainId, DailyTasksV2MergeChainInfo> DailyTasksV2MergeChains { get; set; }

        [GameConfigEntry("DailyTasksV2Settings", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> Member" }, new string[] { }, false)]
        public DailyTasksV2Settings DailyTasksV2Settings { get; set; }
        public List<int> MysteryMachineItemIds { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("EnergyModeEvents", true, null)]
        [GameConfigEntryTransform(typeof(EnergyModeEventSource))]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        public GameConfigLibrary<EnergyModeEventId, EnergyModeEventInfo> EnergyModeEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("MiniEvents", true, null)]
        [GameConfigEntryTransform(typeof(MiniEventConfigSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> MiniEventId #key" }, new string[] { }, false)]
        public GameConfigLibrary<MiniEventId, MiniEventInfo> MiniEvents { get; set; }

        [GameConfigEntryTransform(typeof(MakeYourOwnOfferSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MakeYourOwnOffers", true, null)]
        public GameConfigLibrary<MetaOfferId, MakeYourOwnOfferInfo> MakeYourOwnOffers { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("SoloMilestoneEvents", true, null)]
        [GameConfigEntryTransform(typeof(SoloMilestoneEventInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<SoloMilestoneEventId, SoloMilestoneEventInfo> SoloMilestoneEvents { get; set; }

        [GameConfigEntryTransform(typeof(SoloMilestoneMilestonesInfoSource))]
        [GameConfigEntry("SoloMilestoneMilestones", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<SoloMilestoneMilestonesId, SoloMilestoneMilestonesInfo> SoloMilestoneMilestones { get; set; }

        [GameConfigEntryTransform(typeof(SoloMilestoneTokenSpawnsInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("SoloMilestoneTokenSpawns", true, null)]
        public GameConfigLibrary<SoloMilestoneTokenSpawnsId, SoloMilestoneTokenSpawnsInfo> SoloMilestoneTokenSpawns { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyScoopMilestoneDataSource))]
        [GameConfigEntry("DailyScoopMilestones", true, null)]
        public GameConfigLibrary<DailyScoopMilestoneId, DailyScoopMilestoneData> DailyScoopMilestones { get; set; }

        [GameConfigEntry("DailyScoopStandardObjectives", true, null)]
        [GameConfigEntryTransform(typeof(DailyScoopStandardObjectiveDataSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DailyScoopStandardObjectiveId, DailyScoopStandardObjectiveData> DailyScoopStandardObjectives { get; set; }

        [GameConfigEntry("DailyScoopSpecialObjectives", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyScoopSpecialObjectiveDataSource))]
        public GameConfigLibrary<DailyScoopSpecialObjectiveId, DailyScoopSpecialObjectiveData> DailyScoopSpecialObjectives { get; set; }

        [GameConfigEntry("DailyScoopDays", true, null)]
        [GameConfigEntryTransform(typeof(DailyScoopDayDataSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DailyScoopDayId, DailyScoopDayData> DailyScoopDays { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyScoopWeekDataSource))]
        [GameConfigEntry("DailyScoopWeeks", true, null)]
        public GameConfigLibrary<DailyScoopWeekId, DailyScoopWeekData> DailyScoopWeeks { get; set; }

        [GameConfigEntry("DailyScoopEvents", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyScoopEventInfoSource))]
        public GameConfigLibrary<DailyScoopEventId, DailyScoopEventInfo> DailyScoopEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("TagRewards", true, null)]
        [GameConfigEntryTransform(typeof(TagRewardsSource))]
        public GameConfigLibrary<string, TagRewardsInfo> TagRewards { get; set; }

        [GameConfigEntry("OrderRequirements", true, null)]
        [GameConfigEntryTransform(typeof(OrderRequirementsSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<OrderRequirementsId, OrderRequirements> OrderRequirements { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> Member" }, new string[] { }, false)]
        [GameConfigEntry("GemSettings", true, null)]
        public GemSettings GemSettings { get; set; }

        [GameConfigEntry("MapObjectGroups", true, null)]
        [GameConfigEntryTransform(typeof(MapObjectGroupInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MapObjectGroupId, MapObjectGroupInfo> MapObjectGroups { get; set; }
        public List<ItemDefinition> CutGemItems { get; set; }
        public HashSet<int> CardDeckItems { get; set; }
        public Dictionary<MergeBoardId, CollectibleBoardEventId> GemMineEventBoards { get; set; }
        public HashSet<int> CardItems { get; set; }

        [GameConfigEntry("DailyTasksV2BoultonLeague", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(DailyTaskV2BoultonLeagueSource))]
        public GameConfigLibrary<DailyTaskV2Id, DailyTaskV2BoultonLeagueInfo> DailyTasksV2BoultonLeague { get; set; }

        [GameConfigEntry("DailyTasksV2BoultonLeagueUnlimited", true, null)]
        [GameConfigEntryTransform(typeof(DailyTaskV2BoultonLeagueUnlimitedSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<DailyTaskV2Id, DailyTaskV2BoultonLeagueUnlimitedInfo> DailyTasksV2BoultonLeagueUnlimited { get; set; }

        [GameConfigEntryTransform(typeof(DailyTasksV2ItemBoultonLeagueSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("DailyTasksV2ItemsBoultonLeague", true, null)]
        public GameConfigLibrary<ItemTypeConstant, DailyTasksV2ItemBoultonLeagueInfo> DailyTasksV2ItemsBoultonLeague { get; set; }

        [GameConfigEntry("BoultonLeagueEvents", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(BoultonLeagueEventSource))]
        public GameConfigLibrary<BoultonLeagueEventId, BoultonLeagueEventInfo> BoultonLeagueEvents { get; set; }

        [GameConfigEntry("BoultonLeagueStages", true, null)]
        [GameConfigEntryTransform(typeof(BoultonLeagueStageSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<BoultonLeagueStageId, BoultonLeagueStageInfo> BoultonLeagueStages { get; set; }

        [GameConfigEntry("ItemsInPocket", true, null)]
        [GameConfigEntryTransform(typeof(ItemInPocketInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        public GameConfigLibrary<ItemInPocketId, ItemInPocketInfo> ItemInPocketInfos { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(TemporaryCardCollectionEventSource))]
        [GameConfigEntry("TemporaryCardCollectionEvents", true, null)]
        public GameConfigLibrary<TemporaryCardCollectionEventId, TemporaryCardCollectionEventInfo> TemporaryCardCollectionEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineLeaderboardConfigSource))]
        [GameConfigEntry("MysteryMachineLeaderboardConfigs", true, null)]
        public GameConfigLibrary<MysteryMachineLeaderboardConfigId, MysteryMachineLeaderboardConfigInfo> MysteryMachineLeaderboardConfigs { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineLeaderboardRewardSource))]
        [GameConfigEntry("MysteryMachineLeaderboardRewards", true, null)]
        public GameConfigLibrary<MysteryMachineLeaderboardRewardId, MysteryMachineLeaderboardRewardInfo> MysteryMachineLeaderboardRewards { get; set; }

        [GameConfigEntryTransform(typeof(MysteryMachineLeaderboardTopRankingRewardSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MysteryMachineLeaderboardTopRankingRewards", true, null)]
        public GameConfigLibrary<MysteryMachineLeaderboardTopRankingRewardId, MysteryMachineLeaderboardTopRankingRewardInfo> MysteryMachineLeaderboardTopRankingRewards { get; set; }

        [GameConfigEntryTransform(typeof(MysteryMachineLeaderboardPercentileRankingRewardSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("MysteryMachineLeaderboardPercentileRankingRewards", true, null)]
        public GameConfigLibrary<MysteryMachineLeaderboardPercentileRankingRewardId, MysteryMachineLeaderboardPercentileRankingRewardInfo> MysteryMachineLeaderboardPercentileRankingRewards { get; set; }

        [GameConfigEntryTransform(typeof(CardCollectionCardInfoSource))]
        [GameConfigEntry("CardCollectionCardInfos", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<CardCollectionCardId, CardCollectionCardInfo> CardCollectionCardInfos { get; set; }

        [GameConfigEntry("CardCollectionCardSetInfos", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(CardCollectionCardSetInfoSource))]
        public GameConfigLibrary<CardCollectionCardSetId, CardCollectionCardSetInfo> CardCollectionCardSetInfos { get; set; }

        [GameConfigEntryTransform(typeof(CardCollectionPackInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("CardCollectionPackInfos", true, null)]
        public GameConfigLibrary<CardCollectionPackId, CardCollectionPackInfo> CardCollectionPackInfos { get; set; }

        [GameConfigEntryTransform(typeof(CardCollectionCardActivationInfoSource))]
        [GameConfigEntry("CardCollection_Card_Activation", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<CardCollectionCardActivationId, CardCollectionCardActivationInfo> CardCollectionCardActivationInfos { get; set; }

        [GameConfigEntry("CardCollection_Packs_Activation", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(CardCollectionPackActivationInfoSource))]
        public GameConfigLibrary<CardCollectionPackActivationId, CardCollectionPackActivationInfo> CardCollectionPackActivationInfos { get; set; }

        [GameConfigEntryTransform(typeof(CardCollectionHiddenRarityActivationInfoSource))]
        [GameConfigEntry("CardCollection_HiddenRarity_Activation", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<CardCollectionHiddenRarityActivationId, CardCollectionHiddenRarityActivationInfo> CardCollectionHiddenRarityActivationInfos { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(CardCollectionSetActivationInfoSource))]
        [GameConfigEntry("CardCollection_Set_Activation", true, null)]
        public GameConfigLibrary<CardCollectionSetActivationId, CardCollectionSetActivationInfo> CardCollectionSetActivationInfos { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("CardCollectionBalanceInfos", true, null)]
        [GameConfigEntryTransform(typeof(CardCollectionBalanceInfoSource))]
        public GameConfigLibrary<CardCollectionBalanceId, CardCollectionBalanceInfo> CardCollectionBalanceInfos { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("CardCollection_EvidenceBoxes", true, null)]
        [GameConfigEntryTransform(typeof(CardCollectionEvidenceBoxSource))]
        public GameConfigLibrary<CardCollectionEvidenceBoxId, CardCollectionEvidenceBoxInfo> CardCollectionEvidenceBoxes { get; set; }

        [GameConfigEntryTransform(typeof(CardCollectionDuplicateRewardSource))]
        [GameConfigEntry("CardCollection_DuplicateCardRewards", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<CardCollectionDuplicateRewardId, CardCollectionDuplicateRewardInfo> CardCollectionDuplicateCardRewards { get; set; }

        [GameConfigEntryTransform(typeof(TaskGroupDefinitionSource))]
        [GameConfigEntry("TaskGroups", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<TaskGroupId, TaskGroupDefinition> TaskGroups { get; set; }

        [GameConfigEntry("RewardContainers", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(RewardContainerSource))]
        public GameConfigLibrary<RewardContainerId, RewardContainerInfo> RewardContainers { get; set; }

        [GameConfigEntry("MysteryMachineScreens", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineScreenSource))]
        public GameConfigLibrary<MysteryMachineScreenId, MysteryMachineScreenInfo> MysteryMachineScreens { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(MysteryMachineScreenMessagePackSource))]
        [GameConfigEntry("MysteryMachineScreenMessagePacks", true, null)]
        public GameConfigLibrary<MysteryMachineScreenMessagePackId, MysteryMachineScreenMessagePackInfo> MysteryMachineScreenMessagePacks { get; set; }

        [GameConfigEntryTransform(typeof(MysteryMachineScreenMessageSource))]
        [GameConfigEntry("MysteryMachineScreenMessages", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MysteryMachineScreenMessageId, MysteryMachineScreenMessageInfo> MysteryMachineScreenMessages { get; set; }

        [GameConfigEntry("FallbackItems", true, null)]
        [GameConfigEntryTransform(typeof(FallbackItemInfoSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<FallbackItemId, FallbackItemInfo> FallbackItems { get; set; }

        [GameConfigEntry("FallbackPlayerRewards", true, null)]
        [GameConfigEntryTransform(typeof(FallbackPlayerRewardInfoSource))]
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

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(TheGreatEscapeMinigameInfoSource))]
        [GameConfigEntry("TheGreatEscapeMinigames", true, null)]
        public GameConfigLibrary<TheGreatEscapeMinigameId, TheGreatEscapeMinigameInfo> TheGreatEscapeMinigames { get; set; }
        public List<ItemDefinition> PrisonBadgeItems { get; set; }
        public List<ItemDefinition> PrisonerLetterItems { get; set; }
        public Dictionary<MergeBoardId, CollectibleBoardEventId> TheGreatEscapeEventBoards { get; set; }

        [GameConfigEntryTransform(typeof(DelayedOfferPurchaseRequirementSource))]
        [GameConfigEntry("OfferPurchaseRequirements", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<MetaOfferId, DelayedOfferPurchaseRequirement> DelayedOfferPurchaseRequirements { get; set; }

        [GameConfigEntry("ProgressionPacks", true, null)]
        [GameConfigEntryTransform(typeof(ProgressionPackSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<ProgressionPackId, ProgressionPack> ProgressionPacks { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("ProgressionPackEvents", true, null)]
        [GameConfigEntryTransform(typeof(ProgressionPackEventSource))]
        public GameConfigLibrary<ProgressionPackEventId, ProgressionPackEventInfo> ProgressionPackEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("RewardUpgradables", true, null)]
        [GameConfigEntryTransform(typeof(RewardUpgradableSource))]
        public GameConfigLibrary<RewardUpgradableId, RewardUpgradableInfo> RewardUpgradables { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "#StartDate -> Schedule.Start.Date", "#StartTime -> Schedule.Start.Time" }, new string[] { "# -> Schedule." }, false)]
        [GameConfigEntry("ShortLeaderboardEvents", true, null)]
        [GameConfigEntryTransform(typeof(ShortLeaderboardEventSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        public GameConfigLibrary<ShortLeaderboardEventId, ShortLeaderboardEventInfo> ShortLeaderboardEvents { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("ShortLeaderboardEventStages", true, null)]
        [GameConfigEntryTransform(typeof(ShortLeaderboardEventStageSource))]
        public GameConfigLibrary<ShortLeaderboardEventStageId, ShortLeaderboardEventStageInfo> ShortLeaderboardEventStages { get; set; }

        [GameConfigEntry("SharedProducerSettings", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(SharedProducerSettingsSource))]
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
        [GameConfigEntryTransform(typeof(CardCollectionSupportingEventSource))]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntry("CardCollection_SupportingEvents", true, null)]
        public GameConfigLibrary<CardCollectionSupportingEventId, CardCollectionSupportingEventInfo> CardCollectionSupportingEvents { get; set; }

        [GameConfigEntry("CardCollection_SupportingEvents_Packs", true, null)]
        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(CardCollectionSupportingEventReplacementPackSource))]
        public GameConfigLibrary<CardCollectionPackId, CardCollectionSupportingEventReplacementPackInfo> CardCollectionSupportingEventsReplacementPacks { get; set; }
        public Dictionary<ValueTuple<CardStars, TemporaryCardCollectionEventId>, DuplicateRewardPair> DuplicateRewards { get; set; }
        public Dictionary<MergeBoardId, CollectibleBoardEventId> DigEventMergeBoards { get; set; }

        [GameConfigSyntaxAdapter(new string[] { "ConfigKey -> ConfigKey #key" }, new string[] { }, false)]
        [GameConfigEntryTransform(typeof(AreasGlobalUnlockRequirementSource))]
        [GameConfigEntry("AreasGlobalUnlockRequirements", true, null)]
        public GameConfigLibrary<AreasGlobalUnlockRequirementId, AreasGlobalUnlockRequirementInfo> AreasGlobalUnlockRequirements { get; set; }
    }
}