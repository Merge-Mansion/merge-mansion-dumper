using Metaplay.Core.Model;
using Metaplay.Core.League.Player;
using Metaplay.Core.League;
using Metaplay.Core.MultiplayerEntity;
using System;
using Metaplay.Core;

namespace GameLogic.Player.Leaderboard.ShortLeaderboardEvent
{
    [MetaSerializableDerived(5)]
    [SupportedSchemaVersions(1, 1)]
    public class ShortLeaderboardEventDivisionModel : LeaderboardBotEventDivisionModel<ShortLeaderboardEventDivisionModel, ShortLeaderboardEventParticipantState, ShortLeaderboardEventDivisionAvatar>, IMetacorePlayerDivisionModel<ShortLeaderboardEventDivisionModel, ShortLeaderboardEventParticipantState>, IPlayerDivisionModel<ShortLeaderboardEventDivisionModel>, IPlayerDivisionModel, IDivisionModel, IMultiplayerModel, IModel, ISchemaMigratable, IDivisionModel<ShortLeaderboardEventDivisionModel>, IMultiplayerModel<ShortLeaderboardEventDivisionModel>, IModel<ShortLeaderboardEventDivisionModel>
    {
        public ShortLeaderboardEventDivisionModel()
        {
        }
    }
}