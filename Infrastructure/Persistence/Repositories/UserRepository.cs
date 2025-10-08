using Domain.Aggregates.Users;
using Infrastructure.Persistence.DbContext;

namespace Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User GetById(Guid id)
        {
            // 实际项目中应做实体到领域对象的转换，这里简单处理
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public User GetByName(string name)
        {
            return _context.Users.FirstOrDefault(u => u.Name == name);
        }
    }
}