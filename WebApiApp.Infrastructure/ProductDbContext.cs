using Microsoft.EntityFrameworkCore;

namespace WebApiApp.Infrastructure

{

    public class ProductDbContext : DbContext
    {
    
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
