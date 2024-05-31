using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Access_Specifier
{
	public class Bank
	{
			public long AccountNumber { get; set; }
			public string Name { get; set; }
			public int Balance { get; set; }

			public Bank(long accountNumber, string name, int initialBalance)
			{
				AccountNumber = accountNumber;
				Name = name;
				Balance = initialBalance;
			}

			public void WithdrawAmount(int amount)
			{
				if (amount > 0 && amount <= Balance)
				{
					Balance -= amount;
					Console.WriteLine($"Withdrawn: {amount}. Remaining balance: {Balance}");
				}
				else
				{
					Console.WriteLine("Insufficient funds or invalid amount!");
				}
			}

			public void Deposit(int amount)
			{
				if (amount > 0)
				{
					Balance += amount;
					Console.WriteLine($"Deposited: {amount}. New balance: {Balance}");
				}
				else
				{
					Console.WriteLine("Invalid amount for deposit!");
				}
			}

			public string GetAccountInfo()
			{
				return $"Account Number: {AccountNumber}\nName: {Name}\nBalance: {Balance}";
			}

			public int GetBalance()
			{
				return Balance;
			}
	}
}
