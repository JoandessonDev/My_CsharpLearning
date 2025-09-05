using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error, não é possivel dividir por zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Formato Incerido Invalido", e.Message);
            }
            finally
            {
                Console.WriteLine("Encerrando...");
            }
        }
    }
}