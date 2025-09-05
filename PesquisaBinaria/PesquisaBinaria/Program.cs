using System;

namespace Mynamespace
{
    class AlgoritimosProgram
    {
        static void Main(string[] args)
        {
            int[] vect = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



            PesquisaBinaria(vect, 7);

        }
        static int PesquisaBinaria(int[] vect, int numero)
        {
            int baixo = 0;
            int alto = vect.Length -1;

            while (baixo <= alto)
            {
                int medio = (baixo + alto) / 2;
                int chute = vect[medio];

                if (chute == numero)
                {
                    return chute;
                }
                if (chute < numero)
                {
                    baixo = medio + 1;

                }
                else
                {
                    alto = medio - 1;
                }
                Console.WriteLine(chute);
                
            }
            return 0;
        }

    }
    
}
