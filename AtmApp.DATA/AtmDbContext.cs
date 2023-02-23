using System;
using Microsoft.EntityFrameworkCore;

namespace AtmApp.DATA
{
    public class AtmDbContext: DbContext
    {
        public AtmDbContext(DbContextOptions<AtmDbContext> options) : base(options)
        {}

        public void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
