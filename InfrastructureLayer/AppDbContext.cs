using DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=app.db");
        }
    }
}
