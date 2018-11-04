using System;
using WebTracker.Domain.Base;

namespace WebTracker.Domain
{
    public class WorkDay: BaseEntity
    {
        public int WorkDayId { get; set; }
        public DateTime CurrentDate { get; set; }
    }
}