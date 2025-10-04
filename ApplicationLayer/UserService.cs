using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
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
    }
}
