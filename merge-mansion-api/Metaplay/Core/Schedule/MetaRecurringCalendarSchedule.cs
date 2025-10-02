using Metaplay.Core.Model;
using System;
using Metaplay.Core.Forms;
using Metaplay.Core.Config;

namespace Metaplay.Core.Schedule
{
    [MetaSerializableDerived(1)]
    [MetaFormClassValidator(typeof(MetaRecurringCalendarSchedule.FormValidator))]
    public class MetaRecurringCalendarSchedule : MetaScheduleBase, IGameConfigBuildTimeValidate
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaCalendarDateTime Start { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaCalendarPeriod Duration { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public MetaCalendarPeriod EndingSoon { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public MetaCalendarPeriod Preview { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaCalendarPeriod Review { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public MetaCalendarPeriod? Recurrence { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int? NumRepeats { get; set; }

        private MetaRecurringCalendarSchedule()
        {
        }

        public MetaRecurringCalendarSchedule(MetaScheduleTimeMode timeMode, MetaCalendarDateTime start, MetaCalendarPeriod duration, MetaCalendarPeriod endingSoon, MetaCalendarPeriod preview, MetaCalendarPeriod review, MetaCalendarPeriod? recurrence, int? numRepeats)
        {
        }

        class FormValidator : MetaFormValidator<MetaRecurringCalendarSchedule>
        {
        }
    }
}