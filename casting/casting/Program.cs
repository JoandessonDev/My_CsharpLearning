using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Write a Char: ");
            char letter = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Write a Float number:  ");
            float num2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(num);
            Console.WriteLine(letter);
            Console.WriteLine(num2.ToString("F2",CultureInfo.InvariantCulture));

            Console.WriteLine("Write your name, idade, altura e sexo:");

            string[] box = Console.ReadLine().Split(' ');
            
            string name = box[0];
            int age = int.Parse(box[1]);
            double hight = double.Parse(box[2], CultureInfo.InvariantCulture);
            char sex = char.Parse(box[3].ToUpper());

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(age);
            Console.WriteLine(hight.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(sex);

        }
    }
}
