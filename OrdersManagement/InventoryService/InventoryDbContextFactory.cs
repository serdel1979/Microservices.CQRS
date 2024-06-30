using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace InventoryService
{
    public class InventoryDbContextFactory : IDesignTimeDbContextFactory<InventoryDbContext>
    {
        public InventoryDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<InventoryDbContext>();
            var connectionString = configuration.GetConnectionString("InventoryDatabase");
            optionsBuilder.UseNpgsql(connectionString);

            return new InventoryDbContext(optionsBuilder.Options);
        }
    }
}
