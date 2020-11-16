
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing.Context
{
    public class TestingDbContext: DbContext
    {
        public TestingDbContext(DbContextOptions<TestingDbContext> options): base(options)
        {

        }

        public DbSet<Bill> Bill { get; set; }
        public DbSet<BillDetail> BillDetail { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
