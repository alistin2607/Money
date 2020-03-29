using System;

namespace Money.DB
{
    public class Saving
    {
        public Guid ID { get; set; }
        public double Sum { get; set; }
        public Goal SavingGoal { get; set; }
        public bool Paid { get; set; }
    }
}