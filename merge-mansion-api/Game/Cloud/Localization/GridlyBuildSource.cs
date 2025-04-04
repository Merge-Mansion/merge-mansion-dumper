using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Metaplay.Core.Forms;
using System;

namespace Game.Cloud.Localization
{
    [MetaSerializableDerived(200)]
    public class GridlyBuildSource : GameConfigBuildSource
    {
        [MetaFormNotEditable]
        [MetaMember(1, (MetaMemberFlags)0)]
        public string Name { get; set; }

        [MetaValidateRequired]
        [MetaMember(2, (MetaMemberFlags)0)]
        [GridlyBranchFieldTypeHint]
        public string Branch { get; set; }
        public override string DisplayName { get; }

        private GridlyBuildSource()
        {
        }

        public GridlyBuildSource(string name, string branch)
        {
        }
    }
}