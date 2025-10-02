namespace Game.Cloud.Config
{
    public interface IConfigDefinition<TKeyObject, TValueObject> : IConfigDefinitionValidation
    {
        TKeyObject ConfigKey { get; }
    }
}