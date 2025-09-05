using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterfaces.Services
{
    class TaxPaypal : ITaxContrato
    {
        public double Tax(double amount)
        {
            return amount * 0.02;
        }
    }
}
