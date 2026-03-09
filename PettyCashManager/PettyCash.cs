using System;
using System.Collections.Generic;
using System.Linq;

public enum TransactionStatus { Pending, Approved, Rejected }
// public enum Role { Requester, Approver, Accountant, Auditor }




class PettyCashFund
{
    public void Expense()
    {

        bool run=true;
        while (run)
        {
            
        Console.WriteLine("Please Enter the Categories:\n1. Stationery\n2. Travel\n3. Refreshments\n4. Courier\n5. Exit");
        int Choice=Convert.ToInt32(Console.ReadLine());
        switch (Choice)
        {
            case 1:
            Console.WriteLine("You are inside Stationery");
            break;

            case 2:
            Console.WriteLine("You are inside Travel");
            break;

            case 3:
            Console.WriteLine("You are inside Refreshments");
            break;

            case 4:
            Console.WriteLine("You are inside Courier");
            break;

            case 5:

            break;
        }
        }
    }
}
