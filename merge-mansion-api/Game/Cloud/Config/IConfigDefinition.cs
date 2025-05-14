namespace Game.Cloud.Config
{
    public interface IConfigDefinition<TKeyObject, TValueObject>
    {
        TKeyObject ConfigKey { get; }
    }
}