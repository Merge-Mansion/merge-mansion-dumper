using Metacore.MergeMansion.Common.Options;
using Metaplay.Core.Activables;

namespace Code.GameLogic.GameEvents
{
    public interface ICoreSupportEventModel : ILevelEventModel
    {
        ICoreSupportEventInfo CoreSupportEventInfo { get; }

        Option<ICoreSupportEventMinigameModel> MinigameModelOption { get; }

        MetaActivableState.Activation? LatestActivation { get; }

        CoreSupportEventId ConfigKey { get; }
    }
}