using System;

namespace Money.DB
{
    public class PlannedExpenditure
    {
        public Guid ID { get; set; }
        // sum by plan
        public double SumPlan { get; set; }
        // sum by fact
        public double SumFact { get; set; }
        public string Name { get; set; }
        public DateTime? PayBefore { get; set; }
        public bool Paid { get; set; }

    }
}