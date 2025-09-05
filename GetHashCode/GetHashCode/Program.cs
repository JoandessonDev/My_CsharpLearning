using GetHashCode;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr = new User { Email = "joandesson.dev@gmail.com" };

            User user2 = new User { Email = "joandesson.dev@gmail.com" };
            Console.WriteLine(usr.Equals(user2));
            
        }
    }
}