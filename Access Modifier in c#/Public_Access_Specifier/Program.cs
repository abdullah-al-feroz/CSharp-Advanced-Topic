using Public_Access_Specifier;

Bank bank = new Bank(4543256323, "Faysal", 1000);
Console.WriteLine(bank.GetAccountInfo());

// Example transactions
bank.Deposit(500);
bank.WithdrawAmount(200);
Console.WriteLine(bank.GetAccountInfo());