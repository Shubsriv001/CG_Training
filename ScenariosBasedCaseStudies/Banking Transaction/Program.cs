using System;
using BankSystem;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the account number:");
        string accNo = Console.ReadLine();

        Console.WriteLine("Enter the initial balance:");
        decimal balance = decimal.Parse(Console.ReadLine());

        BankingSystem bankingSystem_obj = new BankingSystem(accNo, balance);

        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("Enter the choice:");
        int choice=Convert.ToInt32(Console.ReadLine());

        if(choice==1 || choice == 2)
        {
            

        try
        {
            if (choice == 1)
            {
                Console.WriteLine("Enter the amount to deposit:");
                decimal amount = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Balance amount: " + bankingSystem_obj.Deposit(amount));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the amount to withdraw:");
                decimal amount = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Balance amount: " + bankingSystem_obj.Withdraw(amount));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        }
        else
        {
            System.Console.WriteLine("Please Enter Valid Choice.");
            return;
        }
    }
}
