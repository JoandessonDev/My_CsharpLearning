using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\JOANDESSON\Desktop\C#\Course_Nelio\Classes Abstratas";

            string targetPath = @"C:\Users\JOANDESSON\Desktop\C#\Course_Nelio\Classes Abstratas\targetFolder\file2.txt";

            try
            {
                var folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
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
