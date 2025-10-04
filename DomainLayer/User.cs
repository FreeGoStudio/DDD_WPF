using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
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
