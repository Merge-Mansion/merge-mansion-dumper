using Metaplay.Core.Model;
using Metaplay.Core.League.Player;
using Metaplay.Core.League;
using Metaplay.Core.MultiplayerEntity;

namespace GameLogic.Player.Leaderboard.ClassicRacesEvent
{
    [MetaSerializableDerived(6)]
    [SupportedSchemaVersions(1, 1)]
    public class ClassicRacesEventDivisionModel : LeaderboardBotEventDivisionModel<ClassicRacesEventDivisionModel, ClassicRacesEventDivisionParticipantState, ClassicRacesEventDivisionAvatar>, IMetacorePlayerDivisionModel<ClassicRacesEventDivisionModel, ClassicRacesEventDivisionParticipantState>, IPlayerDivisionModel<ClassicRacesEventDivisionModel>, IPlayerDivisionModel, IDivisionModel, IMultiplayerModel, IModel, ISchemaMigratable, IDivisionModel<ClassicRacesEventDivisionModel>, IMultiplayerModel<ClassicRacesEventDivisionModel>, IModel<ClassicRacesEventDivisionModel>
    {
        public ClassicRacesEventDivisionModel()
        {
        }
    }
}