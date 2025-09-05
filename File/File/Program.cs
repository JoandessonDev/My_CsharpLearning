using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\JOANDESSON\Desktop\C#\Course_Nelio\Logic_with_C#\File\file1.txt";
            //string targetPath = @"C:\Users\JOANDESSON\Desktop\C#\Course_Nelio\Logic_with_C#\File\file2.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                /*
                FileInfo fileInfo = new FileInfo(sourcePath);   
                //fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                */
                //fs = new FileStream(sourcePath, FileMode.Open);
                sr = File.OpenText(sourcePath);

                List<string> lines = new List<string>();
                while(!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine());
                }

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
                

    
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occoured");
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (fs != null) { fs.Close(); }
                if (sr != null) { sr.Close(); }
            }
        }
    }
}