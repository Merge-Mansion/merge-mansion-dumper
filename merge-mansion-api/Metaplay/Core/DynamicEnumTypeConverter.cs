using System;

namespace Metaplay.Core
{
    public class DynamicEnumTypeConverter : StringTypeConverterHelper<IDynamicEnum>
    {
        private Type _dynamicEnumType;
    }
}