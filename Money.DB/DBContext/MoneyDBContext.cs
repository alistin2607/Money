using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace Money.DB
{
    public class MoneyDBContext : DbContext
    {
        public MoneyDBContext(DbContextOptions<MoneyDBContext> options)
            : base(options)
        {
        }

        public DbSet<Month> Months { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PlannedExpenditure> PlannedExpenditures { get; set; }
        public DbSet<Saving> Savings { get; set; }
    }
}
