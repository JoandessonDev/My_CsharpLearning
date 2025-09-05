using System;
using ConsoleApp2;
namespace mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double? x = null;
            double y = x ?? 876;

            Console.WriteLine(y);
        }
    }
}