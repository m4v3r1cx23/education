namespace Bank;

public class BankAccount(string accountNumber, decimal balance)
{
  private readonly string accountNumber = accountNumber;
  private decimal balance = balance;

  public string GetAccountNumber()
  {
    Console.WriteLine($"Account Number: {accountNumber}");

    return accountNumber;
  }

  public decimal GetBalance()
  {
    Console.WriteLine($"Balance of {accountNumber} is {balance}");

    return balance;
  }

  public void Deposit(decimal amount)
  {
    Console.WriteLine($"Depositing {amount} to {accountNumber}.");

    balance += amount;

    Console.WriteLine($"Balance after operation: {balance}");
  }

  public decimal Withdrawal(decimal amount)
  {
    Console.WriteLine($"Withdrawing {amount} from {accountNumber}.");

    if (balance < amount)
    {
      throw new Exception($"Not enought funds. Account {accountNumber} balance is {balance}");
    }

    balance -= amount;

    Console.WriteLine($"Balance after operation: {balance}");

    return amount;
  }
}