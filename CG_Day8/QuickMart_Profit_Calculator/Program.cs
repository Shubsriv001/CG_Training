using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Text;
using Microsoft.VisualBasic;

class Program
{
    public static void Main(String[]args){
        Console.WriteLine();
      Console.WriteLine("================== QuickMart Traders ==================");
        Console.WriteLine();

        QuickMartTraders quickMartTraders_obj=new QuickMartTraders();
        bool run=true;
        while (run)
        {
         Console.WriteLine("1)Create New Transaction (Enter Purchase & Selling Details)\n2)View Last Transaction\n3)Calculate Profit/Loss (Recompute & Print)\n4)Exit");
       Console.WriteLine();
        Console.WriteLine("Enter your option:");
        
        int choice=Convert.ToInt32(Console.ReadLine());
            if (choice == 4)
            {
                Console.WriteLine("Thank you. Application closed normally.");
                return;
            }

            else
            {
                switch (choice)
                {
                    case 1:
                    quickMartTraders_obj.CreateNewTransaction();    
                    break;

                    case 2:
                    quickMartTraders_obj.ViewLastTransaction();
                    break;

                    case 3:
                    quickMartTraders_obj.CalculateProfit_Loss();
                    break;

                    case 4:
                        Console.WriteLine("Thank you. Application closed normally.");
                            run =false;
                    break;

                    
                    default:
                        Console.WriteLine("Please Enter the valid Input...");
                    break;
                }
            }
        }
    }
}