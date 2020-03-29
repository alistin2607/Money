using System;

namespace Money.DB
{
    public class Income
    {
        public Guid ID { get; set; }
        public double Sum { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
    }
}