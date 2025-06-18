using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Code.GameLogic.Player.Board;

namespace GameLogic.Player.Board
{
    [MetaSerializable]
    public struct Coordinate : ICoordinate
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int X { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int Y { get; set; }

        public static Coordinate Invalid;
        public static Coordinate Zero;
        public bool IsInvalid { get; }

        [IgnoreDataMember]
        public IEnumerable<ICoordinate> CrossNeighbours { get; }

        [IgnoreDataMember]
        public IEnumerable<ICoordinate> Clockwise3x3 { get; }

        [IgnoreDataMember]
        public IEnumerable<ICoordinate> ClockwiseLarger3x3 { get; }
    }
}