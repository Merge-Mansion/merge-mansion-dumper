using Metaplay.Core.MultiplayerEntity;
using Metaplay.Core.Model;

namespace Metaplay.Core.League.Player
{
    public interface IPlayerDivisionModel<TDivisionModel> : IPlayerDivisionModel, IDivisionModel, IMultiplayerModel, IModel, ISchemaMigratable, IMetaIntegration<ISchemaMigratable>, IMetaIntegration, IDivisionModel<TDivisionModel>, IMultiplayerModel<TDivisionModel>, IModel<TDivisionModel>
    {
    }

    [PlayerLeaguesEnabledCondition]
    public interface IPlayerDivisionModel : IDivisionModel, IMultiplayerModel, IModel, ISchemaMigratable, IMetaIntegration<ISchemaMigratable>, IMetaIntegration
    {
        IPlayerDivisionModelServerListenerCore ServerListenerCore { get; }

        IPlayerDivisionModelClientListenerCore ClientListenerCore { get; }
    }
}