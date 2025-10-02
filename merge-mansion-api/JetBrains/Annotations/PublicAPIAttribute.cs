using System;

namespace JetBrains.Annotations
{
    [MeansImplicitUse((ImplicitUseTargetFlags)3)]
    [AttributeUsage((AttributeTargets)32767, Inherited = false)]
    public class PublicAPIAttribute : Attribute
    {
        public PublicAPIAttribute()
        {
        }
    }
}