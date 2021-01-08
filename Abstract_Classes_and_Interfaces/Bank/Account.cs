using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        private long _accountNumber;
        private string _customerName;
        protected double Balance = 500;

        protected virtual void SetDetails(string name, long number)
        {
            this._customerName = name;
            this._accountNumber = number;
        }
        protected virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }
        protected virtual void Deposit(double amount)
        {
            Balance += amount;
        }
        public virtual void Display()
        {
            Console.WriteLine("\n\nA/C No. \tCustomer Name \t Balance ($)");
            Console.WriteLine(_accountNumber + " \t\t " + _customerName + " \t " + Balance);
        }
        protected abstract double BankCharges();
    }
}
