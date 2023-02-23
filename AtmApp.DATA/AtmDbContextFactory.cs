using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Linq;

namespace AtmApp.DATA
{
    public class AtmDbContextFactory : IDesignTimeDbContextFactory<AtmDbContext>
    {
        public AtmDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<AtmDbContext>();
            var connString = @"Data Source=KAYBANGZ;Initial Catalog=AtmDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            optionBuilder.UseSqlServer(connString);
            Console.WriteLine(connString);
            return new AtmDbContext(optionBuilder.Options);
        }
    }
}
