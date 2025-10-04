using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public interface IUserRepository
    {
        User GetById(Guid id);
        User GetByName(string name);
        void Add(User user);
    }
}
