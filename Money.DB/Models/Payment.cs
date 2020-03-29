using System;

namespace Money.DB
{
    public class Payment
    {
        public Guid ID { get; set; }
        public double Sum { get; set; }
        public string Comment { get; set; }
        public virtual Category Category { get; set; }
    }
}