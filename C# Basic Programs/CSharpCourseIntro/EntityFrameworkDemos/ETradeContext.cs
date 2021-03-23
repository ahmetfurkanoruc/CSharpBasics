using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EntityFrameworkDemos
{
    public class ETradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
