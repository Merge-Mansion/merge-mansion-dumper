using System;
using Metaplay.Core.Config;

namespace Metaplay.Core
{
    public interface IMetaRef : IMetaRefBase
    {
        bool IsResolved { get; }

        IMetaRef CreateResolved(IGameConfigDataResolver resolver);
        object MaybeRefObject { get; }
    }
}