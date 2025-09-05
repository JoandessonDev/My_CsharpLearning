using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal value)
        {
            Saldo += value;
                
        }
    }
}
