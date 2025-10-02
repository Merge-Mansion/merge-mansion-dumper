using Metaplay.Core.Model;
using Metaplay.Core.Forms;
using System;
using System.Text.RegularExpressions;

namespace Metaplay.Core.Config
{
    [MetaSerializableDerived(101)]
    public class GoogleSheetBuildSource : GameConfigBuildSource
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaValidateRequired]
        [MetaFormDisplayProps("Google Spreadsheet Name", DisplayHint = "Name of the Google Spreadsheet to use as a data source.", DisplayPlaceholder = "Enter Google Spreadsheet Name")]
        public string Name { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MetaFormFieldCustomValidator(typeof(GoogleSheetBuildSource.GoogleSheetsIdValidator))]
        [MetaFormDisplayProps("Google Spreadsheet ID", DisplayHint = "ID of the Google Spreadsheet to use as a data source.", DisplayPlaceholder = "Enter Google Spreadsheet ID")]
        public string SpreadsheetId { get; set; }
        public override string DisplayName { get; }

        private GoogleSheetBuildSource()
        {
        }

        public GoogleSheetBuildSource(string name, string spreadsheetId)
        {
        }

        private class GoogleSheetsIdValidator : MetaFormValidator<string>
        {
            private static Regex validator;
        }
    }
}