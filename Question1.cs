using System;

namespace Targil_3_1
{
    class Account
    {
        protected int accountNumber;
        protected double balance;

        public Account(int accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                Console.WriteLine("Withdraw completed");
            }
            else
            {
                Console.WriteLine("Not enough money");
            }

            Console.WriteLine("Balance: " + balance);
        }
    }

    class VipAccount : Account
    {
        public VipAccount(int accountNumber, double balance)
            :base(accountNumber, balance)
        {

        }

        public override void Withdraw(double amount)
        {
            if (balance - amount >= -5000)
            {
                balance -= amount;
                Console.WriteLine("VIP withdraw completed");
            }
            else
            {
                Console.WriteLine("Not enough money");
            }

            Console.WriteLine("Balance: " + balance);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account regularAccount = new Account(111, 1000);
            VipAccount vipAccount = new VipAccount(222, 1000);

            Console.WriteLine("Regular Account:");
            regularAccount.Withdraw(2000);

            Console.WriteLine();

            Console.WriteLine("VIP Account:");
            vipAccount.Withdraw(2000);
        }
    }
}