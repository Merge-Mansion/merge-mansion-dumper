using Metaplay.Core.Model;
using System;

namespace Metaplay.Core.Analytics
{
    [MetaSerializable]
    public class AnalyticsLabel : DynamicEnum<AnalyticsLabel>
    {
        protected AnalyticsLabel(int value, string name) : base(value, name, true)
        {
        }
    }
}