using Microsoft.EntityFrameworkCore;

public class InventoryContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public InventoryContext(DbContextOptions<InventoryContext> options)
        : base(options)
    {
    }
}