using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new(2024, 07, 29, 8, 0, 0);

            Console.WriteLine(dateTime.ElapsedTime());

            string phrase = "Olá meu nome é Joandesson";

            Console.WriteLine(phrase.Cut(8));
        }
    }
}
