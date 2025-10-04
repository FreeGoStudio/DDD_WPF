using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

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
