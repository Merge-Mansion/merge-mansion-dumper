using Metaplay.Core.Forms;
using System;

namespace GameLogic.Config
{
    public class ValidateItemDefMetaMemberAttribute : MetaFormFieldValidatorBaseAttribute
    {
        public override string ValidationRuleName { get; }
        public override object ValidationRuleProps { get; }
        public override Type CustomValidatorType { get; }
    }
}