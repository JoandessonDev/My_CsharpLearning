using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exHeranca.Entites
{
    internal class OutsourceEmployee : Employee
    {
        public double AddtionalCharge { get; set; }

        public OutsourceEmployee() { }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AddtionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + (1.1 * AddtionalCharge);
        }
    }
}
