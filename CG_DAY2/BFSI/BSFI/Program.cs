using System;
class Program
{
public static void Main(string[] args) { 

       bool run=true;
       while (run)
       {

           Console.WriteLine("1. Check Loan Eligibility\r\n2. Calculate Tax\r\n3. Enter Transactions\r\n4. Exit");
           int choice = 0;
           Console.WriteLine("Enter the Coice");
           choice = Convert.ToInt32(Console.ReadLine());

           if (choice == 4)
           {
               Console.WriteLine("You have Exited from the Selection Process");
               return;
           }



           switch (choice)
           {
               case 1:

                   Console.WriteLine("Enter Your age: ");
                   int age = Convert.ToInt32(Console.ReadLine());
                   if (age >= 21)
                   {
                       Console.WriteLine("Your eligible");

                   }
                   else
                   {
                       Console.WriteLine("You are not Eligible To take loan");
                   }
                   Console.WriteLine("----------------------------------------------");
                   Console.WriteLine();

                   break;

               case 2:
                   float tax_amount = 0.0f;
                   Console.WriteLine("Enter Your amount: ");
                   float amount = Convert.ToSingle(Console.ReadLine());
                   if (amount < 0)
                   {
                       Console.WriteLine("Enter Positive Amount");

                   }
                   else
                   {
                       if (amount <= 250000)
                       {
                           Console.WriteLine($"You needt to pay {tax_amount}");
                       }

                       else if (amount > 250001 && amount <= 500000)
                       {
                           tax_amount = (amount * 5 / 100);
                           Console.WriteLine($"You needt to pay {tax_amount}");
                       }

                       else if (amount > 500001 && amount <= 1000000)
                       {
                           tax_amount = (amount * 20 / 100);
                           Console.WriteLine($"You needt to pay {tax_amount}");
                       }

                       else if (amount > 1000000)
                       {
                           tax_amount = (amount * 3 / 100);
                           Console.WriteLine($"You need to pay {tax_amount}");
                       }
                   }
                   Console.WriteLine("----------------------------------------------");


                   Console.WriteLine();

                   break;

               case 3:
                   Console.WriteLine("Enter the Number of Transaction");
                   int transcation_number = Convert.ToInt32(Console.ReadLine());

                       int deposited_money = 0;
                   if (transcation_number <= 5)
                   {
                       int[] arr = new int[transcation_number];

                       Console.WriteLine($"Deposit the money");
                       int money = Convert.ToInt32((Console.ReadLine()));
                       if (money < 0)
                       {
                           Console.WriteLine("PLease Enter the Money Greater than 0 ");
                           return;
                       }
                       else
                       {


                           for (int i = 0; i < arr.Length; i++)
                           {
                               arr[i] = money;
                           }

                           for (int i = 0; i < arr.Length; i++)
                           {
                               deposited_money += arr[i];
                           }

                           Console.WriteLine($"total Deposited amount are: {deposited_money}");

                       }
                   }



                   else
                   {
                       Console.WriteLine($"More than 5 Tractions in not allowed You have Entered {transcation_number}");
                   }

                   Console.WriteLine("----------------------------------------------");

                   Console.WriteLine();
                   break;

               case 4:
                   Console.WriteLine("exit");
                   run = false;
                   Console.WriteLine("----------------------------------------------");

                   Console.WriteLine();
                   break;

               default:
                   Console.WriteLine("Invelid Input");
                   break;

           }
       }

       }

}

