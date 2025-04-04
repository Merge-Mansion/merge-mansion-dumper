using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using Metaplay.Core.Forms;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1)]
    [MetaBlockedMembers(new int[] { 3, 4, 5, 6, 100 })]
    public class MergeMansionGameConfigBuildParameters : GameConfigBuildParameters
    {
        public override bool IsIncremental { get; }

        public MergeMansionGameConfigBuildParameters()
        {
        }

        [MetaFormNotEditable]
        [Obsolete]
        [MetaMember(1, (MetaMemberFlags)0)]
        public string LegacySpreadSheetTitle { get; set; }

        [MetaFormNotEditable]
        [Obsolete]
        [MetaMember(2, (MetaMemberFlags)0)]
        public string LegacySpreadSheetUrl { get; set; }
    }
}