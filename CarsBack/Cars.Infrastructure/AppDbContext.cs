using Microsoft.EntityFrameworkCore;
using Cars.Domain;

namespace Cars.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<Car> Cars => Set<Car>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}