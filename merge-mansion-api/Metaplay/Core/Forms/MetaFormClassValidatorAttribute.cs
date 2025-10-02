using System;

namespace Metaplay.Core.Forms
{
    [AttributeUsage((AttributeTargets)1036, AllowMultiple = true, Inherited = true)]
    public class MetaFormClassValidatorAttribute : Attribute
    {
        public Type CustomValidatorType { get; }

        public MetaFormClassValidatorAttribute(Type customValidatorType)
        {
            CustomValidatorType = customValidatorType;
        }
    }
}