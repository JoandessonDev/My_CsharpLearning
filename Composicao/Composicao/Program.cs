using Composicao.Entites;
using Composicao.Entites.Enums;
using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            Departament depart = new Departament(Console.ReadLine());
            Console.WriteLine("Enter Worker Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level: (Junior/MedLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel> (Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse (Console.ReadLine());

            Worker worker = new Worker(name, level, baseSalary, depart);

            Console.Write("How many contracts to this worker? ");
            int nContract = int.Parse (Console.ReadLine());

            for (int i = 0; i < nContract; i++)
            {
                Console.WriteLine($"Entender {i+1} Contract's data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime dateCont = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double hourValue = double.Parse(Console.ReadLine());
                Console.Write("Duration: ");
                int hour = int.Parse(Console.ReadLine());

                
                HourContract contract = new HourContract(dateCont, hourValue, hour); 
                worker.AddContract(contract);
            }

            Console.WriteLine("Enter Moth and Year to calcule income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine();

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month)}");




        }
    }
}