using Bank;

var bankAccount = new BankAccount("1234567890", 100.00m);

bankAccount.GetAccountNumber();
bankAccount.GetBalance();

bankAccount.Deposit(100.00m);

try
{
  bankAccount.Withdrawal(200.01m);
}
catch (Exception e)
{
  Console.WriteLine(e.Message);
}

bankAccount.Withdrawal(200.00m);