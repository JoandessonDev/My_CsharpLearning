using System;
using System.Globalization;
using exHeranca.Entites;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list_Employee = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numEmployee = int.Parse(Console.ReadLine());


            for (int i = 0; i < numEmployee; i++)
            {
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced (y/n): ");
                char response = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valueperHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (response == 'y')
                {
                    Console.Write("Addtional Charge: ");
                    double addtionalCharge = double.Parse(Console.ReadLine());

                    list_Employee.Add(new OutsourceEmployee(name, hours, valueperHour, addtionalCharge));
                }
                else
                {
                    list_Employee.Add(new Employee(name, hours, valueperHour));
                }
            }

            foreach (Employee emp in list_Employee)
            {
                Console.WriteLine(emp.Name + " - $ " + (emp.Payment(), CultureInfo.InvariantCulture));
            }
        }
    }
}