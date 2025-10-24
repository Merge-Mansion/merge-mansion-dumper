using System;

namespace JetBrains.Annotations
{
    [AttributeUsage((AttributeTargets)32767, Inherited = false)]
    [MeansImplicitUse((ImplicitUseTargetFlags)3)]
    public class PublicAPIAttribute : Attribute
    {
        public PublicAPIAttribute()
        {
        }
    }
}