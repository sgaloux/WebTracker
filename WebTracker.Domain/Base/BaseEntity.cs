using System;

namespace WebTracker.Domain.Base
{
    public abstract class BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
