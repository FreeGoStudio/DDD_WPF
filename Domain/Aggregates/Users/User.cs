namespace Domain.Aggregates.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public User()
        {
        }

        public User(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        // 领域行为
        public void ChangeName(string newName)
        {
            Name = newName;
        }
    }
}