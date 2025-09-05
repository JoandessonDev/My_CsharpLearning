using Heranca01.Entites;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Jhon", 3000.00);

            BussinesAccount bussinesAccount = new BussinesAccount(
                2005,
                "Joandesson",
                1000.00,
                300

                );
            bussinesAccount.Loan(150);
            //Console.WriteLine(bussinesAccount.Balance);

            //UPCASTING

            Account account1 = bussinesAccount;

            Account account2 = new SavingsAccount(4500, "Alex", 3000, 0.1);

            

            //DOWNCASTING

            if (account2 is BussinesAccount)
            {
                BussinesAccount acc2 = (BussinesAccount)account2;
            }

            if(account2 is SavingsAccount)
            {
                SavingsAccount acc3 = (SavingsAccount)account2;
            }
            account2.Withdraw(300);
            Console.WriteLine(account2.Balance);


        }
    }
}