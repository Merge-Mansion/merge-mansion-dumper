using System.Collections.Generic;

namespace GameLogic.Player.Requirements
{
    public interface IHasRequirements
    {
        IEnumerable<PlayerRequirement> Requirements { get; }
    // STUB
    }
}