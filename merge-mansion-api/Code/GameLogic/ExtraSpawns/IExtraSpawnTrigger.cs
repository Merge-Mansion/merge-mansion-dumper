using Metaplay.Core.Model;

namespace Code.GameLogic.ExtraSpawns
{
    [MetaSerializable]
    public interface IExtraSpawnTrigger
    {
        ExtraSpawnTriggerType Type { get; }
    }
}