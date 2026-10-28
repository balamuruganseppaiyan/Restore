
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data;

public class StoreContext(DbContextOptions<StoreContext> options)
    : DbContext(options)
{
    public DbSet<Product> Products { get; set; } = null!;
}



