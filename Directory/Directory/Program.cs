using System;
using System.IO;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JOANDESSON\Desktop\testedoc";
            try
            {
               var folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Directory.CreateDirectory(path + @"\newfolder");

                foreach ( var file in files )
                {
                    Console.WriteLine(file);
                }
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);

                    
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}