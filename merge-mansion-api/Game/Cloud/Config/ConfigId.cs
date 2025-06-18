using Metaplay.Core.Model;
using System;

namespace Game.Cloud.Config
{
    [MetaSerializableDerived(4)]
    public class ConfigId<TKeyObject, TValueObject> : ConfigDefinition<TKeyObject, TValueObject>
    {
        [MetaMember(100, (MetaMemberFlags)0)]
        private int TypeCode { get; set; }
        public Type ConcreteType { get; set; }

        protected ConfigId()
        {
        }

        public ConfigId(TKeyObject key, Type concreteType)
        {
        }
    }
}