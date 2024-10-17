using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options)
        {
        }

#pragma warning disable SA1101 // Prefix local calls with this
        public DbSet<Product> Products => Set<Product>();
#pragma warning restore SA1101 // Prefix local calls with this

#pragma warning disable SA1101 // Prefix local calls with this
        public DbSet<Order> Orders => Set<Order>();
#pragma warning restore SA1101 // Prefix local calls with this
    }
}
