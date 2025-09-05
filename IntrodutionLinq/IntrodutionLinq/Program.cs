using System;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vec = { 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = vec.Where(x => x % 2 == 0).Select(x => x * 10);

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}