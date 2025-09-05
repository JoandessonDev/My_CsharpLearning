using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Conta
    {
        protected decimal Saldo;

        public abstract void Creditar(decimal value);   

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo da Conta: {Saldo}");
        }
    }
}
