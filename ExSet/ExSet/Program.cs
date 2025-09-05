using System;
using System.IO;
using ExSet.Entites;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JOANDESSON\Desktop\C#\Course_Nelio\Logic_with_C#\ExSet\test.txt";

            HashSet<LogRecord> set = new();    
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] lines = sr.ReadLine().Split(' ');

                        string username = lines[0];
                        
                        set.Add(new LogRecord { Username = username});
                        
                    }
                    foreach(LogRecord record in set)
                    {
                        Console.WriteLine(record);
                    }
                    Console.WriteLine("Total User: " + set.Count);
                }

            }
            catch (IOException e) 
            {
                Console.WriteLine("An Error Ocurred:");
                Console.WriteLine(e.Message);
            }

        }
    }
}