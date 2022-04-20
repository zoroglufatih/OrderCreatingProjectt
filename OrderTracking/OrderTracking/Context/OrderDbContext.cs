using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using OrderTracking.Models;

namespace OrderTracking.Context
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<SizeSetSize>()
                .HasKey(x => new
                {
                    x.SizeId,
                    x.SizeSetId
                });
        }

        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Pattern> Patterns { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<SizeSet> SizeSets { get; set; }
        public DbSet<SizeSetSize> SizeSetSizes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
