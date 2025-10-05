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

        public void ApplyMigrations()
        {
            Database.Migrate(); // 自动应用所有未执行的迁移
        }
    }
}
