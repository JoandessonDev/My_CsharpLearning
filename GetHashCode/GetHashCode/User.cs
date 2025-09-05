using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCode
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User() { }
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is User))
            {
                Console.WriteLine("No equals");
                return false;
            }
            User other = obj as User;

            return (Email.Equals(other.Email));
           

        }
    }
}
