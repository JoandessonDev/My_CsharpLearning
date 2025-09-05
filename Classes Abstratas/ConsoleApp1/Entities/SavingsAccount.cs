using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount (int number, string houder, double balance, double interestRate) : base (number, houder, balance)
        {
            InterestRate = interestRate;
        }
    }
}
