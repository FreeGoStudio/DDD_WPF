using DomainLayer;

namespace ApplicationLayer
{
    public interface IUserService
    {
        void CreateUser(string name);
        User GetUser(Guid id);
        User GetUserByName(string name);
    }
}
