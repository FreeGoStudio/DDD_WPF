using Domain;

namespace Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(string name)
        {
            var user = new User(Guid.NewGuid(), name);
            _userRepository.Add(user);
        }

        public User GetUser(Guid id)
        {
            return _userRepository.GetById(id);
        }

        public User GetUserByName(string name)
        {
            return _userRepository.GetByName(name);
        }
    }
}