using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class BussinesAccount : Account
    {

        public double LoanLimit { get; set; }
        public BussinesAccount()
        {
        }
        public BussinesAccount(int number, string houder, double balance, double loanLimit)
            : base(number, houder, balance)
        {

            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (LoanLimit < amount)
            {
                Balance += amount;
            }
        }

    }
}
