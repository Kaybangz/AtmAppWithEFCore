using AtmApp.DATA.Entities;
using Microsoft.EntityFrameworkCore;

namespace AtmApp.DATA
{
    public class AtmDbContext : DbContext
    {
        public AtmDbContext(DbContextOptions<AtmDbContext> options) : base(options)
        { }


        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Transfer> Transfers { get; set; } = null!;

        
    }
}
