using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JOANDESSON\Desktop\C#\Course_Nelio\Logic_with_C#\File\file1.txt";

            using (StreamReader sr = File.OpenText(path))
            {

                try
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}