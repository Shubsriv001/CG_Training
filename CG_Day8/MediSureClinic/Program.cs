using System;
using Medical;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================== MediSure Clinic Billing ==================");

        PtientBill pb = new PtientBill();
        bool run=true;

        while (run)
        {
            Console.WriteLine("Enter your option:");
            Console.WriteLine("1) Create New Bill");
            Console.WriteLine("2) View Last Bill");
            Console.WriteLine("3) Clear Last Bill");
            Console.WriteLine("4) Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    pb.CreateNewBill();
                    break;

                case 2:
                    pb.ViewLastBill();
                    break;

                case 3:
                    pb.ClearLastBill();
                    break;

                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                        run=false;
                    break;

                default:
                    Console.WriteLine("Invalid Selection. Please try again.");
                    break;
            }
        }
    }
}
