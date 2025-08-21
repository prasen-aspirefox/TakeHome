using System.Collections.Generic;
using System.Reflection.Emit;

namespace TakeHome.Infrastructure.Data
{
    // Infrastructure/Data/AppDbContext.cs
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        // Optional Fluent API config
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }

}
