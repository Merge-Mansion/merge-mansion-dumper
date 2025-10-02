using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using GameLogic.Player.Board;
using System;
using System.Collections.Generic;
using GameLogic.Player.Items;
using System.Runtime.Serialization;
using Metaplay.Core.Offers;
using Metaplay.Core;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(12)]
    public class MysteryMachineEventModel : MetaActivableState<MysteryMachineEventId, MysteryMachineEventInfo>, IBoardEventModel
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public sealed override MysteryMachineEventId ActivableId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MysteryMachine MysteryMachine { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public MergeBoard MergeBoard { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int EnterMergeBoardCount { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private byte BoolFields { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public List<IBoardItem> PocketItems { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public int EventInstance { get; set; }
        public bool PortalItemGiven { get; set; }
        public bool EnterBoardDialogueTriggered { get; set; }
        public bool PreviewNoted { get; set; }
        public bool StartNoted { get; set; }
        public bool EndNoted { get; set; }

        [IgnoreDataMember]
        public IBoardEventInfo BoardEventInfo { get; }

        [IgnoreDataMember]
        public bool RequestExtension { get; set; }

        [IgnoreDataMember]
        public OfferPlacementId BoardShopPlacementId { get; }

        [IgnoreDataMember]
        public OfferPlacementId BoardShopFlashPlacementId { get; }

        private MysteryMachineEventModel()
        {
        }

        public MysteryMachineEventModel(MysteryMachineEventInfo info)
        {
        }

        [MetaMember(8, (MetaMemberFlags)0)]
        public EventInstanceId EventInstanceId { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public MetaTime? StartTimeInGameConfig { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public AcknowledgedMysteryMachineLeaderboardPositionData AcknowledgedLeaderboardPositionData { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public HashSet<PlayerSegmentId> LeaderboardRewardSegmentsAtStartOfEvent { get; set; }
        public bool LeaderboardRewardsClaimed { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        private MysteryMachineLeaderboardConfigId CachedLeaderboardConfigId { get; set; }
        public int SelectedPortalItem { get; }
    }
}