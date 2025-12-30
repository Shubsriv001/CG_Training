using System;

// Custom exception
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message) { }
}

class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException(
                "Initial balance cannot be negative",
                nameof(initialBalance));

        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException(
                "Withdrawal amount must be greater than zero",
                nameof(amount));

        if (amount > Balance)
            throw new InsufficientBalanceException(
                $"Cannot withdraw {amount:C}. Available balance: {Balance:C}");

        Balance -= amount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount bankAccount_obj = new BankAccount(5000);
        bankAccount_obj.Withdraw(1000);
        Console.WriteLine(bankAccount_obj.Balance);
    }
}
