using System;
using System.Collections.Generic;

namespace Money.DB
{
    public class Day
    {
        public Guid ID { get; set; }
        public int Number { get; set; }
        // avaliable sum on day (Budget month divided by days count)
        public double Budget { get; set; }
        // Budget minus sum of expenses
        public double Saldo { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}