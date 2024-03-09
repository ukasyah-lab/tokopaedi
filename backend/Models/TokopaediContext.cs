using Microsoft.EntityFrameworkCore;

namespace backend.Models;

public class TokopaediContext : DbContext
{
  public TokopaediContext(DbContextOptions<TokopaediContext> options)
      : base(options)
  {
  }

  public DbSet<ProductCategory> ProductCategories { get; set; } = null!;
}
