using System;
namespace PayRollPro
{
    
class PayrollBoard
{
    public int[] R_eType;
    public string[] R_eName;
    public int[] R_eHourly_Rate;
    public double[] R_eMonthly_bonus;
    public int[] R_eWeekly_hours = new int[4];
    public int r_number;

    public void RegisterEmployee()
    {
        Console.WriteLine("Please Enter how many user you want to register:");
        r_number = Convert.ToInt32(Console.ReadLine());

        R_eType = new int[r_number];
        R_eName = new string[r_number];
        R_eHourly_Rate = new int[r_number];
        R_eMonthly_bonus = new double[r_number];

        for (int i = 0; i < r_number; i++)
        {
            Console.WriteLine($"Enter Employee {i + 1} Name");
            string emp_name = Console.ReadLine();
            if (emp_name == "")
            {
                Console.WriteLine("Name cannot be empty");
                return;
            }
            R_eName[i] = emp_name;

            Console.WriteLine("Enter Employee Type(1- FullTime, 2- PartTime, 3- Contract)");
            int emp_type = Convert.ToInt32(Console.ReadLine());
            if (emp_type < 1 || emp_type > 3)
            {
                Console.WriteLine("Invalid Employee Type");
                return;
            }
            R_eType[i] = emp_type;

            Console.WriteLine("Enter Hourly Rate");
            int emp_hourly_rate = Convert.ToInt32(Console.ReadLine());
            if (emp_hourly_rate < 0)
            {
                Console.WriteLine("Hourly Rate cannot be negative");
                return;
            }
            R_eHourly_Rate[i] = emp_hourly_rate;

            Console.WriteLine("Enter Monthly Bonus");
            double emp_monthly_bonus = Convert.ToDouble(Console.ReadLine());
            if (emp_monthly_bonus < 0)
            {
                Console.WriteLine("Monthly Bonus cannot be negative");
                return;
            }
            R_eMonthly_bonus[i] = emp_monthly_bonus;

            Console.WriteLine("Enter Weekly hours (Week 1 to 4):");
            for (int w = 0; w < 4; w++)
            {
                Console.WriteLine($"Enter Week {w + 1} hours:");
                R_eWeekly_hours[w] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Employee registered Successfully.");
        }
    }

    public void ShowOvertimeSummary()
    {
        int count = 0;

        Console.WriteLine("Please Enter the hours Threshold");
        int Emp_hoursThreshold = Convert.ToInt32(Console.ReadLine());

        if (Emp_hoursThreshold < 0)
        {
            Console.WriteLine("Please Enter the Valid Hourly Threshold");
            return;
        }
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("Below is the list of Employee Who Did OverTime Work.");
        Console.WriteLine();

        
        for (int i = 0; i < R_eWeekly_hours.Length; i++)
        {
            if (R_eWeekly_hours[i] > Emp_hoursThreshold)
            {
                count++;
                Console.WriteLine($"Employee Name: {R_eName[0]}, Weekly Hours: {R_eWeekly_hours[i]}");
            }
        }
        Console.WriteLine();

        if (count == 0)
        {
            Console.WriteLine("No Employee Did Overtime");
        Console.WriteLine();
        }
    }
}

}