using Metaplay.Core.Model;
using GameLogic.Player.Board;
using System;
using Code.GameLogic.GameEvents;
using System.Collections.Generic;

namespace GameLogic.Utility
{
    [MetaSerializableDerived(1)]
    public class TheGreatEscapeRevertLogic : BaseRevertLogic
    {
        [MetaMember(11, (MetaMemberFlags)0)]
        private Coordinate _itemCoordinate;
        [MetaMember(12, (MetaMemberFlags)0)]
        private int _itemConfigKey;
        [MetaMember(13, (MetaMemberFlags)0)]
        private CollectibleBoardEventId _eventId;
        [MetaMember(14, (MetaMemberFlags)0)]
        private TheGreatEscapeMinigameId _minigameId;
        [MetaMember(15, (MetaMemberFlags)0)]
        private int _lastProgress;
        [MetaMember(16, (MetaMemberFlags)0)]
        private List<int> _visualProgress;
        [MetaMember(17, (MetaMemberFlags)0)]
        private int _tapProgress;
    }
}