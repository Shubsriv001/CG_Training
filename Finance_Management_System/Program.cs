using System;
using Finance_Management_System;

class Financial_Management_System
{
    public static void Main(string[] args)
    {
        Credit credit_obj = new Credit();
        Debit debit_obj = new Debit();

        bool run = true;
        while (run)
        {
            Console.WriteLine("1. Debit Operations\n2. Credit Operations\n3. Exit");
            Console.WriteLine("Enter Your Selection");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. ATM Withdrawal Limit\n2. EMI Burden Evaluation\n3. Minimum Balance Compliance Check\n4. Transaction Based Daily Spending Calculator\n5. Exit");
                    Console.WriteLine("Enter Your Selection");

                    int debit_choice = Convert.ToInt32(Console.ReadLine());
                    switch (debit_choice)
                    {
                        case 1:
                            debit_obj.ATM_Withdrawal_Limit();
                            break;

                        case 2:
                            debit_obj.EMI_Burden_Evaluation();
                            break;

                        case 3:
                            debit_obj.Minimum_Balance_Compliance_Check();
                            break;

                        case 4:
                            debit_obj.Transaction_Based_Daily_Spending_Calculator();
                            break;


                        case 5:
                            Console.WriteLine("You Exit from the menu.");
                            break;

                        default:
                            Console.WriteLine("Invalid selection");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("1. Net Salary Credit Calculation\n2. Fixed Deposit Maturity Calculation\n3. Employee Bonus Eligibility Check\n4. Credit Card Reward Points Evaluation\n5. Exit");
                    Console.WriteLine("Enter Your Selection");

                    int credit_choice = Convert.ToInt32(Console.ReadLine());
                    switch (credit_choice)
                    {
                        case 1:
                            credit_obj.Net_Salary_Credit_Calculation();
                            break;

                        case 2:
                            credit_obj.Fixed_Deposit_Maturity_Calculation();
                            break;

                        case 3:
                            credit_obj.Employee_Bonus_Eligibility_Check();
                            break;

                        case 4:
                            credit_obj.Credit_Card_Reward_Points_Evaluation();
                            break;
                            
                        case 5:
                            Console.WriteLine("You Exit from the Selection menu.");
                            break;
                    

                        default:
                            Console.WriteLine("Invalid selection");
                            break;
                    }
                    break;

                case 3:
                    run = false;
                    Console.WriteLine("You are Out From the selection Process");
                    break;

                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }
        }
    }
}
