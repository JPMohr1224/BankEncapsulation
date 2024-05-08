using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		

		private double balance;

        public BankAccount(double amount)
        {
            balance = amount;
        }

        public void Deposit(double ammount)
		{
            balance += ammount;
            Console.WriteLine($"You have deposited {balance}");
		}

	    public double GetBalance()
		{
            Console.WriteLine($"Your balance is {balance}");
            return balance;
		}

        public void Withdraw(double amount)
        {
            balance -= amount;
            Console.WriteLine($"Your new balance is {balance}");
        }

        public BankAccount()
        {
        }
    }
}

