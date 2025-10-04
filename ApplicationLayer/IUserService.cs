using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public interface IUserService
    {
        void CreateUser(string name);
        User GetUser(Guid id);
        User GetUserByName(string name);
    }
}
