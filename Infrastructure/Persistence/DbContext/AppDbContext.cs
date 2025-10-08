using Domain.Aggregates.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.DbContext
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=app.db");
        }
    }
}