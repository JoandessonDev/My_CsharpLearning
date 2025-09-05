using System;

namespace Dicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            int password = 1;
            while (password != 0)
            {
                Console.WriteLine("USER:    ");
                string email = Console.ReadLine();

                Console.WriteLine("Password");
                password = int.Parse(Console.ReadLine());

                dic.Add(password, email);
            }
            foreach (KeyValuePair<int, string> v in dic)
            {
                Console.WriteLine(v);
            }
        }
    }
}