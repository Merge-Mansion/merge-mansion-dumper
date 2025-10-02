using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using Metaplay.Core.Analytics;

namespace Metaplay.Core.Localization
{
    [MetaSerializable]
    public struct LocalizedString : ILocalized<string>, ILocalized
    {
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        [MetaMember(1, (MetaMemberFlags)0)]
        public Dictionary<LanguageId, string> Localizations { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string LocalizationKey { get; set; }
    }
}