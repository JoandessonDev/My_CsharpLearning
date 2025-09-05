using Genercs;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.WriteLine("How Many values do you wish add?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
               int x =  int.Parse(Console.ReadLine());
               printService.AddValue(x);
            }
            printService.Print();
            Console.WriteLine("Firt: " + printService.Frist());
        }
    }
}