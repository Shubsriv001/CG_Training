using System;

namespace Finance_Management_System;

class Credit
{


public void Net_Salary_Credit_Calculation()
    {
        Console.WriteLine("Please Enters gross salary: ");
        int user_gross_Salary=Convert.ToInt32(Console.ReadLine());
        float user_net_Salary=0.0f;
        user_net_Salary=user_gross_Salary-user_gross_Salary*10/100;
        Console.WriteLine($"Net salary credited: ₹{user_net_Salary}");
    }


    public void Fixed_Deposit_Maturity_Calculation()
    {
       Console.WriteLine("Please Enter Principle Amount: ");
       float user_principle_Amount=(Convert.ToSingle(Console.ReadLine()));
        if (user_principle_Amount < 0)
        {
            Console.WriteLine("Please enter the Valid Amount.");
            return;

        }
        else
        {
            

       Console.WriteLine("Please Enter Rate Of Interest: ");
       float user_Rate_Interest=(Convert.ToSingle(Console.ReadLine())); 
       Console.WriteLine("Please Enter Time period in Months: ");
       float user_time_Period=(Convert.ToSingle(Console.ReadLine())); 

       float user_Simple_Interest=(user_principle_Amount*user_Rate_Interest*(user_time_Period/12))/100;
       float user_maturity_amount=user_principle_Amount+user_Simple_Interest;
       Console.WriteLine($"Fixed Deposit maturity amount: {user_maturity_amount}");
    }
        }


    public void Employee_Bonus_Eligibility_Check()
    {
        Console.WriteLine("Please Enter Your Annual Salary");
        int user_annual_Salary=Convert.ToInt32(Console.ReadLine());

        if (user_annual_Salary < 0)
        {
            Console.WriteLine("Please enter the valid Amount.");
            return;
        }
        else
        {
            

        Console.WriteLine("Please Enter Your Year Of Service");
        float user_Year_of_Service=Convert.ToSingle(Console.ReadLine());
        if(user_annual_Salary>=500000 && user_Year_of_Service >= 3)
        {
            Console.WriteLine("Employee is eligible for bonus.");
        }
        else
        {
            
            Console.WriteLine("Employee is not eligible for bonus. He/She need Annual Salary >=500000 And Year Of Service >=3");
        }
    }
        }



public void Credit_Card_Reward_Points_Evaluation()
    {
        Console.WriteLine("Please Enter Credit Card Spend Amount");
        int user_credit_card_spend_Amt=Convert.ToInt32(Console.ReadLine());
        if (user_credit_card_spend_Amt < 0)
        {
            Console.WriteLine("Please enter the Valid Amount.");
            return;
        }
        else
        {
            
        int credit_rewards_point=0;
        credit_rewards_point=user_credit_card_spend_Amt/100;
        Console.WriteLine($"Reward points earned: {credit_rewards_point}");
        }   
    }  
}