using System;
using System.Collections.Generic;
using System.Text;

namespace Money.DB
{
    public class Month
    {
        public Guid ID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        // avaliable sum on month (income minus mandatory expenses)
        public double Budget { get; set; }
        public double Spent { get; set; }
        // Income minus mandatory expenses, minus spending, minus postponed
        public double Balance { get; set; }
        public virtual ICollection<Day> Days { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
        // Planned or obligatory expenditures
        public virtual ICollection<PlannedExpenditure> PlannedExpenditures { get; set; }
        // Amounts set aside for different purposes
        public virtual ICollection<Saving> Savings { get; set; }
        

    }
}
