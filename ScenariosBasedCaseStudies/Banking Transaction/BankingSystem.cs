using System;

namespace BankSystem
{
    class BankingSystem
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankingSystem(string accountNumber, decimal initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public decimal Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            Balance += amount;
            return Balance;
        }

        public decimal Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds.");

            Balance -= amount;
            return Balance;
        }
    }
}
