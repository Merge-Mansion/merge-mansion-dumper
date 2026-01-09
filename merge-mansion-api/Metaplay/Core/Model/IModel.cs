using System;

namespace Metaplay.Core.Model
{
    public interface IModel<TModel> : IModel, ISchemaMigratable, IMetaIntegration<ISchemaMigratable>, IMetaIntegration
    {
    }

    [MetaSerializable]
    public interface IModel : ISchemaMigratable, IMetaIntegration<ISchemaMigratable>, IMetaIntegration
    {
        int LogicVersion { get; set; }
    }
}