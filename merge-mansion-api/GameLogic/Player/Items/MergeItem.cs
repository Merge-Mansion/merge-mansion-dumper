using System;
using GameLogic.Player.Items.Activation;
using GameLogic.Player.Items.Decay;
using Metaplay.Core;
using Metaplay.Core.Model;
using GameLogic.Merge;
using System.Runtime.Serialization;
using GameLogic.Player.Items.Spawning;
using GameLogic.Player.Items.Chest;
using GameLogic.Player.Items.Boosting;
using GameLogic.Player.Items.Bubble;
using GameLogic.Player.Items.Sink;
using GameLogic.Player.Items.TimeContainer;
using GameLogic.Player.Items.Charges;
using GameLogic.Player.Items.Merging;
using GameLogic.Player.Items.Attachments;
using GameLogic.MergeChains;
using GameLogic.Player.Board.Placement;
using Metaplay.Core.Math;
using GameLogic.Player.Items.Fishing;
using GameLogic.Player.Items.Persistent;
using Merge;
using System.Runtime.CompilerServices;
using GameLogic.Player.Items.Order;
using GameLogic.Config;
using GameLogic.Player.Items.GemMining;
using GameLogic.Config.Types;

namespace GameLogic.Player.Items
{
    [MetaSerializableDerived(2)]
    [MetaBlockedMembers(new int[] { 2 })]
    public class MergeItem : IBoardItem, IMergeItem
    {
        private static readonly MetaTime guaranteedFuture; // 0x0
        [IgnoreDataMember]
        public MergeItem.MergeItemExtra Extra => extra ??= new MergeItemExtra();

        [MetaOnMemberDeserializationFailure("GarageCleanupSpawnerFix")]
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaRef<ItemDefinition> DefinitionRef { get; set; }

        [IgnoreDataMember]
        public DecayState DecayState => Extra.DecayState;

        [IgnoreDataMember]
        public ActivationState ActivationState => Extra.ActivationState;

        [IgnoreDataMember]
        public StorageState ActivationStorageState => Extra.ActivationStorageState;

        [Obsolete("Use IMergeItem.Definition instead")]
        [IgnoreDataMember]
        public ItemDefinition Definition => DefinitionRef.Ref;

        public void ResetStates(MetaTime timestamp)
        {
        }

        public void FlushStorages()
        {
        }

        public bool IsActivationStorageFull()
        {
            return Extra.ActivationStorageState.IsFull(Definition.ActivationFeatures.StorageMax);
        }

        public int GetCurrentAmountInActivationStorage()
        {
            return Extra.ActivationStorageState.GetCurrentAmount();
        }

        public bool TryToFillActivationStorage(MetaTime timestamp)
        {
            // STUB
            return false;
        }

        [MetaSerializable]
        public class MergeItemExtra
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public DecayState DecayState; // 0x10
            [MetaMember(2, (MetaMemberFlags)0)]
            public ActivationState ActivationState; // 0x18
            [MetaMember(4, (MetaMemberFlags)0)]
            public StorageState ActivationStorageState; // 0x28
            [MetaMember(3, (MetaMemberFlags)0)]
            public SpawnState SpawnState;
            [MetaMember(5, (MetaMemberFlags)0)]
            public StorageState SpawnStorageState;
            [MetaMember(6, (MetaMemberFlags)0)]
            public ChestState ChestState;
            [MetaMember(7, (MetaMemberFlags)0)]
            public BoosterState BoosterState;
            [MetaMember(8, (MetaMemberFlags)0)]
            public BubbleState BubbleState;
            [MetaMember(9, (MetaMemberFlags)0)]
            public int SpecialActivationAmount;
            [MetaMember(10, (MetaMemberFlags)0)]
            public ISinkState SinkState;
            [MetaMember(12, (MetaMemberFlags)0)]
            public TimeContainerState TimeContainerState;
            [MetaMember(13, (MetaMemberFlags)0)]
            public ChargesState ChargeState;
            [MetaMember(14, (MetaMemberFlags)0)]
            public XpState ExperienceState;
            [MetaMember(15, (MetaMemberFlags)0)]
            public ItemAttachmentsState AttachmentsState;
            [MetaMember(16, (MetaMemberFlags)0)]
            public ItemLeaderboardState LeaderboardState;
            [MetaMember(17, (MetaMemberFlags)0)]
            public ItemRewardsState RewardsState;
            public MergeItemExtra()
            {
            }

            [MetaMember(18, (MetaMemberFlags)0)]
            public FishingRodState FishingRodState;
            [MetaMember(19, (MetaMemberFlags)0)]
            public WeightState WeightState;
            [MetaMember(20, (MetaMemberFlags)0)]
            public PersistentState PersistentState;
            [MetaMember(21, (MetaMemberFlags)0)]
            public OrderParentState OrderState;
            [MetaMember(22, (MetaMemberFlags)0)]
            public RockChunkState RockChunkState;
            [MetaMember(23, (MetaMemberFlags)0)]
            public GemState GemState;
        }

        [MetaMember(3, (MetaMemberFlags)0)]
        private ItemVisibility visibility;
        [MetaMember(4, (MetaMemberFlags)0)]
        private MergeItem.MergeItemExtra extra;
        [MetaMember(5, (MetaMemberFlags)0)]
        private MetaTime createdAt;
        [IgnoreDataMember]
        public SpawnState SpawnState { get; }

        [IgnoreDataMember]
        public StorageState SpawnStorageState { get; }

        [Obsolete("Use IMergeItem.ChestState instead")]
        [IgnoreDataMember]
        public ChestState ChestState { get; }

        [IgnoreDataMember]
        public BoosterState BoosterState { get; }

        [IgnoreDataMember]
        public BubbleState BubbleState { get; }

        [IgnoreDataMember]
        public int SpecialActivationAmount { get; }

        [IgnoreDataMember]
        public ISinkState SinkState { get; }

        [IgnoreDataMember]
        public TimeContainerState TimeContainerState { get; }

        [IgnoreDataMember]
        public ChargesState ChargesState { get; }

        [IgnoreDataMember]
        public XpState ExperienceState { get; }

        [IgnoreDataMember]
        public ItemAttachmentsState AttachmentsState { get; }

        [IgnoreDataMember]
        public ItemAttachmentsState AttachmentsStateMaybe { get; }

        [IgnoreDataMember]
        public ItemLeaderboardState LeaderboardState { get; }

        [IgnoreDataMember]
        public ItemRewardsState RewardsState { get; }

        [IgnoreDataMember]
        public bool ShowTutorialFingerOnDiscovery { get; }
        public int ItemId { get; }
        public string ItemType { get; }

        [IgnoreDataMember]
        public bool Movable { get; }

        [IgnoreDataMember]
        public ItemVisibility Visibility { get; }

        [IgnoreDataMember]
        public bool SupportsMerge { get; }

        [IgnoreDataMember]
        public MetaDuration? Lifetime { get; }

        [IgnoreDataMember]
        public MetaDuration? RemainingDuration { get; }

        [IgnoreDataMember]
        public bool SupportsActivation { get; }

        [IgnoreDataMember]
        public bool SupportsSpawning { get; }

        [IgnoreDataMember]
        public IPlacement SpawnPlacement { get; }

        [IgnoreDataMember]
        public bool SpawnStorageFull { get; }

        [IgnoreDataMember]
        public MetacoreTime? NextSpawnStorageTimestamp { get; }
        public bool IsChest { get; }

        [IgnoreDataMember]
        public bool IsLootable { get; }
        public MetaDuration? InfiniteEnergyDuration { get; }

        [IgnoreDataMember]
        public bool IsBooster { get; }

        [IgnoreDataMember]
        public bool IsBoosted { get; }

        [IgnoreDataMember]
        public F32 TimeBoostMultiplier { get; }

        [IgnoreDataMember]
        public bool IsAffectedByBooster { get; }
        public bool IsSink { get; }

        [IgnoreDataMember]
        public bool IsConsumable { get; }

        [IgnoreDataMember]
        public int ConsumableCap { get; }
        public bool IsInsideBubble { get; }

        [IgnoreDataMember]
        public BubbleState BubbleStateMaybe { get; }

        [IgnoreDataMember]
        public ValueTuple<Currencies, int> UnlockValue { get; }

        [IgnoreDataMember]
        public bool CanBeUnlocked { get; }

        [IgnoreDataMember]
        public bool IsVisible { get; }

        [IgnoreDataMember]
        public bool IsPartiallyVisible { get; }

        [IgnoreDataMember]
        public bool IsHiddenInABox { get; }

        [IgnoreDataMember]
        public bool VisibilityAllowsMerge { get; }

        [IgnoreDataMember]
        public bool ActivationPaused { get; set; }

        [IgnoreDataMember]
        public MetaDuration RemainingTimeContained { get; }

        [IgnoreDataMember]
        public int RemainingCharges { get; }

        [IgnoreDataMember]
        public bool IsFullyConsumed { get; }

        public MergeItem()
        {
        }

        private MergeItem(ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility)
        {
        }

        public MergeItem(IPlayer player, ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility, bool insideBubble)
        {
        }

        public MergeItem(ItemDefinition resultingItem, MergeItem sourceItem, MetaTime timestamp)
        {
        }

        public MergeItem(ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility, DecayState decayState, ActivationState activationState, StorageState activationStorage, SpawnState spawnState, StorageState spawnStorage, ChestState chestState, ISinkState sinkState, TimeContainerState timeContainerState, ChargesState chargesState, XpState xpState)
        {
        }

        [IgnoreDataMember]
        public FishingRodState FishingRodState { get; }

        [IgnoreDataMember]
        public FishingRodState FishingRodStateMaybe { get; }

        [IgnoreDataMember]
        public WeightState WeightState { get; }

        [IgnoreDataMember]
        public WeightState WeightStateMaybe { get; }

        [IgnoreDataMember]
        public bool CanSpawn { get; }

        [IgnoreDataMember]
        public bool SupportsFishingRodTap { get; }

        [IgnoreDataMember]
        public bool HasFishingRodState { get; }

        [IgnoreDataMember]
        public PersistentState PersistentState { get; }

        public MergeItem(ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility, DecayState decayState, ActivationState activationState, StorageState activationStorage, SpawnState spawnState, StorageState spawnStorage, ChestState chestState, ISinkState sinkState, TimeContainerState timeContainerState, ChargesState chargesState, XpState xpState, PersistentState persistentState)
        {
        }

        public int ItemLevel { get; }

        [IgnoreDataMember]
        private bool CanNotBeSpedUp { get; }

        [IgnoreDataMember]
        public bool UseCalendarBasedCycle { get; }

        [IgnoreDataMember]
        public bool IsSpawnBoosted { get; }

        [IgnoreDataMember]
        public F32 TimeSpawnBoostMultiplier { get; }

        [IgnoreDataMember]
        public bool ActivatedWithNoCost { get; }
        public bool HideSinkProgressBar { get; }
        public bool HideSinkUndiscoveredItemsInHints { get; }

        [IgnoreDataMember]
        public MetacoreTime CreatedAt { get; }

        private static string HotspotTagKey;
        public MergeItem(IPlayer player, ItemDefinition itemDefinition, MetaTime timestamp, MergeBoardId boardId, ItemVisibility itemVisibility, bool insideBubble)
        {
        }

        [IgnoreDataMember]
        public OrderParentState OrderState { get; }

        [IgnoreDataMember]
        public bool IsDecayableOrder { get; }

        [IgnoreDataMember]
        public bool IsActivableOrder { get; }

        [IgnoreDataMember]
        public bool IsSpawnableOrder { get; }
        public bool IsSinkableOrder { get; }

        public MergeItem(SharedGameConfig config, ItemDefinition resultingItem, MergeItem sourceItem, MetaTime timestamp, IPlayer player)
        {
        }

        public MergeItem(ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility, DecayState decayState, ActivationState activationState, StorageState activationStorage, SpawnState spawnState, StorageState spawnStorage, ChestState chestState, ISinkState sinkState, TimeContainerState timeContainerState, ChargesState chargesState, XpState xpState, OrderParentState orderState, PersistentState persistentState)
        {
        }

        [IgnoreDataMember]
        public RockChunkState RockChunkState { get; }

        [IgnoreDataMember]
        public GemState GemState { get; }

        [IgnoreDataMember]
        public bool SupportsRockChunkTap { get; }

        [IgnoreDataMember]
        public bool HasGemWeight { get; }

        public MergeItem(IPlayer player, ItemDefinition itemDefinition, MetaTime timestamp, MergeBoardId boardId, ItemVisibility itemVisibility, bool insideBubble, bool checkNullExtra)
        {
        }

        public MergeItem(ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility, DecayState decayState, ActivationState activationState, StorageState activationStorage, SpawnState spawnState, StorageState spawnStorage, ChestState chestState, ISinkState sinkState, TimeContainerState timeContainerState, ChargesState chargesState, XpState xpState, OrderParentState orderState, PersistentState persistentState, GemState gemState)
        {
        }

        [IgnoreDataMember]
        public bool DecayOnActivation { get; }

        [IgnoreDataMember]
        public bool HasPrisonBadgeState { get; }

        [IgnoreDataMember]
        public bool IsPostBox { get; }

        [IgnoreDataMember]
        public bool IsMinigameActivation { get; }

        [IgnoreDataMember]
        public bool IsEscapeTool { get; }

        [IgnoreDataMember]
        public IItemEffectFeatures ItemActivationEffects { get; }

        [IgnoreDataMember]
        public bool HasActivationVfx { get; }

        [IgnoreDataMember]
        public bool ActivationMiniGame { get; }

        [IgnoreDataMember]
        public bool LargeItem2x2 { get; }

        public MergeItem(IMergeMansionGameConfig config, ItemDefinition resultingItem, MergeItem sourceItem, MetaTime timestamp, IPlayer player)
        {
        }

        private MergeItem(MetaRef<ItemDefinition> definitionRef, MetaTime timestamp, ItemVisibility itemVisibility)
        {
        }

        public MergeItem(IPlayer player, MetaRef<ItemDefinition> itemDefinitionRef, MetaTime timestamp, MergeBoardId boardId, ItemVisibility itemVisibility, bool insideBubble, bool checkNullExtra)
        {
        }

        public MergeItem(IMergeMansionGameConfig config, MetaRef<ItemDefinition> resultingItemRef, IMergeItem sourceItem, MetaTime timestamp, IPlayer player)
        {
        }

        public MergeItem(MetaRef<ItemDefinition> itemDefinitionRef, MetaTime timestamp, ItemVisibility itemVisibility, DecayState decayState, ActivationState activationState, StorageState activationStorage, SpawnState spawnState, StorageState spawnStorage, IChestState chestState, ISinkState sinkState, TimeContainerState timeContainerState, ChargesState chargesState, XpState xpState, OrderParentState orderState, PersistentState persistentState, GemState gemState)
        {
        }

        [IgnoreDataMember]
        public bool ShowGemWeightLabel { get; }

        public MergeItem(IPlayer player, MetaRef<ItemDefinition> itemDefinitionRef, MetacoreTime timestamp, MergeBoardId boardId, ItemVisibility itemVisibility, bool insideBubble, bool checkNullExtra)
        {
        }

        public MergeItem(IMergeMansionGameConfig config, MetaRef<ItemDefinition> resultingItemRef, IMergeItem sourceItem, MetacoreTime timestamp, IPlayer player)
        {
        }

        public MergeChainId ChainId { get; }
    }
}