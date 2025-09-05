namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            int n = 10;
            int[] fib_vet = new int[n + 1];
            fib_vet[0] = 0;
            fib_vet[1] = 1;

            Console.WriteLine(fib_vet[0]);
            Console.WriteLine(fib_vet[1]);

            for (int i = 2; i <= n; i++)
            {
                fib_vet[i] = fib_vet[i - 1] + fib_vet[i - 2];
                Console.WriteLine(fib_vet[i]);
            }
     
        }
    }
}
