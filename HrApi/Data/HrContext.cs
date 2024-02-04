using Microsoft.EntityFrameworkCore;

namespace HrApi.Data
{
    public class HrContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Departemnt> departemnts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost;initial Catalog=HrApi;integrated security=true");
            optionsBuilder.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

    }
}
