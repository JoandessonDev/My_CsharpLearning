using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JOANDESSON\Desktop\C#\Course_Nelio\Logic_with_C#\File\file1.txt";
            string path2 = @"C:\Users\JOANDESSON\Desktop\C#\Course_Nelio\Logic_with_C#\File\file2.txt";

            try
            {
                string[] file1 = File.ReadAllLines(path);

                using( StreamWriter sw = File.AppendText(path2))
                {
                    foreach (string line in file1 )
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

                using(StreamReader sr = File.OpenText(path2))
                {
                    while ( !sr.EndOfStream )
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Ocurued an Error...");
                Console.WriteLine(e.Message);
            }
        }
    }
}