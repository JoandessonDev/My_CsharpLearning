using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Joandesson");
            set.Add("Manuele Lopes Alves");

            foreach (string item in set) { 
                Console.WriteLine(item);
            };

            if (set.Contains("Joandesson")){
                Console.WriteLine("Bem vindo!");
            }
           
            
        }
    }
}