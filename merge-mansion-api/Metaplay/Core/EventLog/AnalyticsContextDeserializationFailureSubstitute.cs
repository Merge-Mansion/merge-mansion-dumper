using Metaplay.Core.Model;
using Metaplay.Core.Analytics;

namespace Metaplay.Core.EventLog
{
    [MetaSerializableDerived(10)]
    public class AnalyticsContextDeserializationFailureSubstitute : AnalyticsContextBase
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public AbstractTypeDeserializationFailureInfo<AnalyticsContextBase> Info { get; }

        public AnalyticsContextDeserializationFailureSubstitute(AbstractTypeDeserializationFailureInfo<AnalyticsContextBase> info)
        {
        }
    }
}