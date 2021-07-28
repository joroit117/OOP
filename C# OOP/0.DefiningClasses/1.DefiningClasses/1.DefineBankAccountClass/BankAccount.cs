using System;
using System.Collections.Generic;
using System.Text;

namespace _1.DefineBankAccountClass
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {this.id}, balance {this.balance}";
        }

        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.ID = id;
                accounts.Add(id, acc);
            }
        }
    }
}
