using System;
namespace Finance_Management_System;
 class Debit
{
    public void ATM_Withdrawal_Limit()
    {
        Console.WriteLine("Please Enter Your Withdrawal Amount");
        float withdrawal_amount=Convert.ToSingle(Console.ReadLine());
        if (withdrawal_amount < 0)
        {
            Console.WriteLine("Please Enter the valid amount");
            return;
        }
        else
        {
        if (withdrawal_amount <= 40000)
        {
            Console.WriteLine("allowed");
        }
        else
        {
            Console.WriteLine("rejected");
        }

    }
        }

    public void EMI_Burden_Evaluation()
    {
        Console.WriteLine("Please Enter Your Monthly Income");
        int user_monthly_Income=Convert.ToInt32(Console.ReadLine());
        if(user_monthly_Income<0 )
        {
            Console.WriteLine("PLease enter the valid amount");
            return;
        }
        else
        {
            
        Console.WriteLine("Please Enter Your EMI Amount");
        int user_EMI_Amount=Convert.ToInt32(Console.ReadLine());

        if( user_EMI_Amount < 0)
        {
            Console.WriteLine("PLease enter the valid amount");
            return;
        }
        else
        {
            
        float user_fourty_percent=0.0f;
        user_fourty_percent=user_monthly_Income*40/100;
        if (user_EMI_Amount > user_fourty_percent)
        {
            Console.WriteLine("EMI exceeds safe income limit");
        }
        else if (user_EMI_Amount < user_fourty_percent)
        {
            Console.WriteLine("EMI is financially manageable.");
        }
    }
        }

        }

public void Minimum_Balance_Compliance_Check()
    {
        
        Console.WriteLine("Please Enter Your Current Amount");
        int user_current_Amount=Convert.ToInt32(Console.ReadLine());

        if (user_current_Amount < 0)
        {
            Console.WriteLine("Please Enter the valid Amount.");
            return;
        }
        else
        {  
        if (user_current_Amount < 2000)
        {
            Console.WriteLine("Minimum balance not maintained. Penalty applicable. You need to maintain more than 2000");
        }

        else if (user_current_Amount > 2000)
        {
            Console.WriteLine("Minimum balance requirement satisfied.");
        }

    }
        }

public void Transaction_Based_Daily_Spending_Calculator()
    {
        Console.WriteLine("Enter Number Of Transaction You Want: ");
        int transaction_Number=Convert.ToInt32(Console.ReadLine());

        if (transaction_Number < 0)
        {
            Console.WriteLine("Please Enter the valid Transaction Number.");
        }
        else
        {
        int []arr=new int[transaction_Number];
        Console.WriteLine("Please Enter The Debited Amount: ");
        int total_Amout=0;
        for(int i = 0; i < arr.Length; i++)
        {
            int debited_Amount=Convert.ToInt32(Console.ReadLine());
                if (debited_Amount < 0)
                {
                    return;
                }
                else
                {
                    
            arr[i]=debited_Amount;
        }
                }

        for(int i = 0; i < arr.Length; i++)
        {
            total_Amout+=arr[i];
        }
        Console.WriteLine($"Total Debit amount for the day: ₹{total_Amout}");

        }
    }
}