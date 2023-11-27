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

		public void Deposit(double amount)
		{
			balance += amount;
		}

		public double GetBalance()
		{
			return balance;
		}

		public void Withdraw(double amount)
		{
            balance -= amount;
		}
	}
}

//A private field of type double named **balance **with a value of 0
//Define a method named Deposit that will accept a double and store that value in the balance field
//Define a method named GetBalance that will return the amount stored in the balance field