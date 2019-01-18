using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Uchet.Models
{
    public class Context: DbContext
    {
        public Context() : base("DefaulConnection") { }

        public DbSet<Providers> Providers { get; set; }
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<AccountingPoints> AccountingPoints { get; set; }
        public DbSet<Nomenclature> Nomenclature { get; set; }
        public DbSet<Profit> Profit { get; set; }
        public DbSet<Expense> Expense { get; set; }

    }
}
