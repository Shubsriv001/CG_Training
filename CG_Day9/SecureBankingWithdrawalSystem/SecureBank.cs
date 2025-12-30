using System;

namespace BankingSystem
{
    class BankExceptions : Exception
    {
        public BankExceptions(string errorMessage) : base(errorMessage) { }
    }

    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    class BankAccount
    {
        public string AccountNumber;
        public decimal Balance;

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            if (accountNumber == null)
            {
                throw new BankExceptions("Account number should not be Null. Enter a valid account number to proceed.");
            }
            else if (accountNumber == "")
            {
                throw new BankExceptions("Account number should not be Empty. Enter a valid account number to proceed.");
            }
            else if (accountNumber.Length < 1)
            {
                throw new BankExceptions("Please Enter a valid Account number.");
            }
            else
            {
                AccountNumber = accountNumber;
                Balance = initialBalance;
            }
        }

        public void Withdraw()
        {
            Console.WriteLine("Please Enter the amount you want to withdraw:");
            decimal w_amt = Convert.ToDecimal(Console.ReadLine());
            if (w_amt > Balance)
            {
                throw new InsufficientBalanceException("Insufficient Balance to proceed with the withdrawal.");
            }
            else
            {
                Balance -= (decimal)w_amt;
                Console.WriteLine($"Withdrawal of {w_amt} is successful. Remaining balance is {Balance}");
            }
        }
    }
}
