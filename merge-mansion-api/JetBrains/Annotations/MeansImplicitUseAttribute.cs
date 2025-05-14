using System;

namespace JetBrains.Annotations
{
    [AttributeUsage((AttributeTargets)18436)]
    public class MeansImplicitUseAttribute : Attribute
    {
        public MeansImplicitUseAttribute()
        {
        }

        public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
        {
        }

        public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
        {
        }
    }
}