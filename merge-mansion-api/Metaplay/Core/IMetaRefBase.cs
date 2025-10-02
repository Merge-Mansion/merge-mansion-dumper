using System;

namespace Metaplay.Core
{
    public interface IMetaRefBase
    {
        Type ItemType { get; }

        object KeyObject { get; }
    }
}