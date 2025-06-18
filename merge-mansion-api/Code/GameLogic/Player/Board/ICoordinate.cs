using System;
using System.Collections.Generic;

namespace Code.GameLogic.Player.Board
{
    public interface ICoordinate
    {
        int X { get; }

        int Y { get; }

        bool IsInvalid { get; }

        IEnumerable<ICoordinate> CrossNeighbours { get; }

        IEnumerable<ICoordinate> Clockwise3x3 { get; }

        IEnumerable<ICoordinate> ClockwiseLarger3x3 { get; }
    }
}