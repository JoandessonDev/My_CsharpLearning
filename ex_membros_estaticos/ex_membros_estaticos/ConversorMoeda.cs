using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_membros_estaticos
{
    internal class ConversorMoeda
    {
        public static double IOF = 0.06;

        public static double ConverterMoeda(double cot, double compra)
        {
            double convert = cot * compra;
            double desconto = convert * 0.06;
            return convert + desconto;
        }
    }
}
