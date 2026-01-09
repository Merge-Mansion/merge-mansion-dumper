using Metaplay.Core.Model;

namespace Metaplay.Core.Player
{
    public interface IPlayerModel<TPlayerModel> : IPlayerModelBase, IModel<IPlayerModelBase>, IModel, ISchemaMigratable, IMetaIntegration<ISchemaMigratable>, IMetaIntegration, IMetaIntegrationConstructible<IPlayerModelBase>, IMetaIntegration<IPlayerModelBase>, IMetaIntegrationConstructible, IRequireSingleConcreteType
    {
    }
}