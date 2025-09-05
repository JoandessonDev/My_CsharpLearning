using System;

namespace Mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "joandesson", "isabela", "Ribamar", "gabriel", "Ruan" };

            foreach (string name in names)
            {
                Console.WriteLine(name.ToUpper());
            }
        }2
    }
}