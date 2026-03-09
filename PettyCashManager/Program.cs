using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("-:Welcome To Petty Cash Management:-");
        Console.WriteLine();


        bool run = true;

        while (run)
        {
            Console.WriteLine("Please select from the options given");
            Console.WriteLine("1. Expense\n2. Approval\n3. Reimbursements\n4. Report\n5. Audit\n6. View Balance\n7. Exit");
            Console.WriteLine();
            Console.WriteLine("Please Enter your Choice:");
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("You are inside Expense");
                    break;

                case 2:
                    Console.WriteLine("You are inside Reimbursements");
                    break;

                case 3:
                    Console.WriteLine("You are inside Report");
                    break;

                case 4:
                    Console.WriteLine("You are inside Audit");
                    break;

                case 5:
                    Console.WriteLine("You are inside View Balance");
                    break;
                case 6:
                    Console.WriteLine("You are out from the Selection Process");
                    Console.WriteLine("Thank You Visit Again...");
                    Console.WriteLine();
                    run=false;
                    return;
                    break;

                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }

    }
}