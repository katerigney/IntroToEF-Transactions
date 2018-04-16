using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace IntroToEF_Transactions.Data
{
    class DataContext : DbContext
    {

        public DataContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Transactions> Transactions { get; set; }
    }
}
