using System;

namespace Mynamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] mat = new int [3,3];

            mat[0,0] = 1;
            mat[1,0] = 2;
            mat[2,0] = 3;

            Console.WriteLine(mat[0,0]);

        }
    }
}
