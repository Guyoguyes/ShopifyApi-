using Microsoft.EntityFrameworkCore;

namespace Shopify.Models;

public class ShopifyContext: DbContext
{
    public ShopifyContext(DbContextOptions<ShopifyContext> options) : base(options)
    {
        
    }
    
    public DbSet<Customer> customer { get; set; }
    public DbSet<Products> products { get; set; }
    public DbSet<Category> category { get; set; }
}