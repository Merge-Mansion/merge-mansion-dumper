using Metaplay.Core.Model;
using GameLogic;

namespace Game.Cloud.Player
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum MetaJourneyPayloadType
    {
        EvaluateJourneys = 0,
        Callback = 1,
        ActionDelivery = 2,
        EvaluationOutcome = 3
    }
}