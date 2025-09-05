using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JOANDESSON\Desktop\testedoc\01\sec01.txt";

            try
            {
                Console.WriteLine(Path.GetDirectoryName(path));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
