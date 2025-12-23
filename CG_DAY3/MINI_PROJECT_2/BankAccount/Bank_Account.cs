using System;
using System.Runtime.InteropServices;

class Bank_Account
{
    int  account_No;
    public double Balance;
    // string bank_Name="SBI";

    public Bank_Account(int Balance,int account_No)
    {
        this.Balance=Balance;
        this.account_No=account_No;
         
    }



    public void Deposit()
    {
        Console.WriteLine("Enter the  Money You want to add in the account:");
        double user_deposited_money=Convert.ToDouble(Console.ReadLine());

        if (user_deposited_money < 0)
        {
            Console.WriteLine("Please Enter Valid Money....");
            return;
        }
        else
        {
            Console.WriteLine("In how Many Part You Want to Deposit Like 1,2,3...");
            int number_time_Deposit=Convert.ToInt32(Console.ReadLine());
            double []arr=new double[number_time_Deposit];
            Console.WriteLine("Please Enter the money You want to Deposit in the Bank");
            for(int i = 0; i < arr.Length; i++)
            {
                double user_deposit_Amt=Convert.ToDouble(Console.ReadLine());
                arr[i]=user_deposit_Amt;

                foreach(double j in arr)
                {
                    Balance+=j;
                }
            }

        }
    }
    public void Withdraw()
    {
        Console.WriteLine("Enter the Amount You want to Withdraw from Your Account:");
        double user_withdraw_Amt=Convert.ToDouble(Console.ReadLine());
        if (user_withdraw_Amt < 0)
        {
            Console.WriteLine("Please Enter the valid Amount to Wthdraw");
            return;
        }
        else if (user_withdraw_Amt > Balance)
        {
            Console.WriteLine($"You Don't have enogh money to withdraw Current Balance is {Balance}");
        }
        else
        {
           Balance-user_withdraw_Amt;
           Console.WriteLine($"You have left with ₹{Balance} Monety in Your Account"); 
        }
        
    }
    public void Display()
    {
        Console.WriteLine($"Total money present in your account is{Balance}");
    }


    public static void Main(string[]args)
    {
        Bank_Account ba_obj=new Bank_Account(1000,001);
        ba_obj.Deposit();
    }
}