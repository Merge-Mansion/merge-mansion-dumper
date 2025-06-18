using System;

namespace GameLogic.Config
{
    public class ConfigLookupValue<TValue>
    {
        public Func<IMergeMansionGameConfig, TValue> GetValue { get; }

        private ConfigLookupValue()
        {
        }

        public ConfigLookupValue(Func<IMergeMansionGameConfig, TValue> getValue)
        {
        }
    }
}