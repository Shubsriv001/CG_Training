using System;
using PayRollPro;
class Program
{
    public static void Main(string[] args)
    {
   
        PayrollBoard payrollBoard_obj = new PayrollBoard(); 

        bool run = true;

        while (run)
        {
            Console.WriteLine("Please Enter Your Choice:\n1) Register Employee\n2) Show Overtime Summary\n3) Exit");
            int choice = Convert.ToInt32(Console.ReadLine()); 
            switch (choice)
            {
                case 1:
                    payrollBoard_obj.RegisterEmployee();
                    break;

                case 2:
                    payrollBoard_obj.ShowOvertimeSummary();
                    break;

                case 3:
                    Console.WriteLine("You Have Exited From the Selection Process:");
                    run = false;
                    break;

                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    break;
            }
        }}}