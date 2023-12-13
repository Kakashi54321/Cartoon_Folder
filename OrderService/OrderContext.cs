using Microsoft.EntityFrameworkCore;

public class OrderContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }

    public OrderContext(DbContextOptions<OrderContext> options)
        : base(options)
    {
    }
}