using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Account
    {
        public int Number {  get; set; }
        public string Houder { get; set; }
        public double Balance { get; set; }
        public Account() {
          
        }
        public Account(int number, string houder, double balance)
        {
            Number = number;
            Houder = houder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
