using AtmApp.DATA;


namespace AtmApp.DOMAIN.Utils
{
    public class DbContextClass
    {
        public static AtmDbContext GetDbContext()
        {
            AtmDbContextFactory atmDbContextFactory = new AtmDbContextFactory();
            var dbContext = atmDbContextFactory.CreateDbContext(null);

            return dbContext;
        }
    }
}
