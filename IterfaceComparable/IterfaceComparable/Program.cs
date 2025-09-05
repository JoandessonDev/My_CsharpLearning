using System;
using System.IO;
using IterfaceComparable.Entites;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JOANDESSON\Desktop\C#\Course_Nelio\Logic_with_C#\IterfaceComparable\texto01.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> employees = new List<Employee>();

                    while (!sr.EndOfStream)
                    {
                        employees.Add(new Employee(sr.ReadLine()));

                    }
                    employees.Sort();
                    foreach (Employee employee in employees)
                    {
                        Console.WriteLine(employee);
                    }
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("Ocurred an Error!");
                Console.WriteLine(e.Message);
            }
        }
    }

}