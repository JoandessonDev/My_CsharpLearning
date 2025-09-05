using Generics;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculationService calculationService = new();

            List<string> list = new();

            list.Add("Joandesson");
            list.Add("Manuele");
            list.Add("Santos");
            list.Add("Adão");
            list.Add("Zeta");

            List<int> list2 = new List<int> { 1, 9, 3 };
            
            Console.WriteLine(calculationService.Max(list2));
        }
    }
}