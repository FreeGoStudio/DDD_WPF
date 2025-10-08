namespace Domain
{
    public interface IUserRepository
    {
        User GetById(Guid id);

        User GetByName(string name);

        void Add(User user);
    }
}