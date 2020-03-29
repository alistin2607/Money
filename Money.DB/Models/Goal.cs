using System;
using System.Collections.Generic;

namespace Money.DB
{
    public class Goal
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual ICollection<Saving> Savings { get; set; }
    }
}