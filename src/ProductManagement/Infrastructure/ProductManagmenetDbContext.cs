using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;

namespace ProductManagement.Infrastructure;
internal class ProductManagmenetDbContext : DbContext
{
    public ProductManagmenetDbContext(DbContextOptions<ProductManagmenetDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Product>();
    }
}
