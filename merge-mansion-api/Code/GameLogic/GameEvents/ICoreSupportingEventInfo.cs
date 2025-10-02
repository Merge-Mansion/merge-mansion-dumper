using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using System;

namespace Code.GameLogic.GameEvents
{
    public interface ICoreSupportingEventInfo<TId> : IMetaActivableConfigData<TId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<TId>, IHasGameConfigKey<TId>, IMetaActivableInfo<TId>, ICoreSupportingEventInfo, IEventSharedInfo
    {
    }

    public interface ICoreSupportingEventInfo : IEventSharedInfo
    {
        string CoreSupportingEventDisplayName { get; }

        string CoreSupportingEventConfigKey { get; }

        CoreSupportingEventType CoreSupportingEventType { get; }
    }
}