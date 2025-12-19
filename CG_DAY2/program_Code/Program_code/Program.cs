using System;
class Program
{
    public static void Main(string[] args)
    {

    //----------------------------FOR-LOOP------------------------------------

        //1) WAP to print the multiple of 5

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(5 * i);
            //}

    // -----------------------------------------------------------------------

        //2)WAP to print the  table of 20

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"20 * {i}= {20*i}");
            //}

    // -----------------------------------------------------------------------

         //3) WAP to print the table from 20 to 30 using Nested loop

            //for(int i = 20; i <= 30; i++)
            //{
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }
            //}

    // -----------------------------------------------------------------------


      //4) WAP  to print all the even number from the range 

             //Console.WriteLine("Enter the number to print all even the number upton:");
             //int number=Convert.ToInt32(Console.ReadLine());
        
             //Console.WriteLine("All the Even number in the range are:");
             //for(int i = 1; i <= number; i++)
             //{
             //    if (i % 2 == 0)
             //    {
             //        Console.WriteLine(i);
             //    }
             //}

    //-----------------------------------------------------------------------------

        //5) WAP to calculate the sum of the number from 1 to n

            //Console.WriteLine("Enter the number");
            //int sum = 0;
            //int num=Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i <= num; i++)
            //{
            //    sum += i;
    
            //}
            //Console.WriteLine($"Sum if the number are: {sum}");

    //----------------------------------------------------------------------------------------

        //6)WAP to print the fibbonacci series upto n

            //Console.WriteLine("Enter the number");
            //int num=Convert.ToInt32(Console.ReadLine());
            //int a = 0;
            //int b = 1;
            //int c;
            //Console.Write(a+" "+b+" ");
            //for (int i = 0; i < num; i++)
            //{
            //    c = a + b;
            //    Console.Write(c+" ");
            //    a = b;
            //    b = c;
            //}

     //-------------------------------------------------------------------------------------------------

        //7) WAP to calculate the power of a number

            //Console.WriteLine("Enter the number to calculate the power of the number");
            //int number=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the power number to calculate:");
            //int power_number=Convert.ToInt32(Console.ReadLine());
            //int after_power_number = Convert.ToInt32(Math.Pow(number, power_number));
            //Console.WriteLine($"Power of the number is: {after_power_number}");

    //--------------------------------------------------------------------------------------------------


    //------------------------JUMP-STATEMENTS--------------------------------------

    //------------------------BREAK-STATEMENT--------------------------------------


        //1)WAP to print the number from 1 to 5 from the loop and using break 

                //for(int i = 1; i <= 10; i++)
                //{
                //    Console.WriteLine(i);
                //    if (i == 5)
                //    {
                //        break;
                //    }
                //}

    //-------------------------------------------------------------------------------------------

    //-----------------------------------Continue-Statement--------------------------------------------------------

        //1) Program to showcase the use of continue statement

            //Console.WriteLine("Game Begin");
            //for(int i = 1; i <= 10; i++)
            //{
            //    if( i == 4)
            //    {
            //        Console.WriteLine("player 4 is invisible");
            //        continue;
            //    }
            //    Console.WriteLine($"player killed e{i}");
            
            
            //}


    //-----------------------------------------------------------------------------------------------

    //---------------------------------------GOTO-STATEMENT-------------------------------------------
            // 1)Implementation of goto 

                //    int i = 1;
                //start:
                //    Console.WriteLine(i);

                //    i++;
                //    if (i <= 5)
                //    {
                //        goto start;
                //    }

    //------------------------------------------------------------------------------------------

    // Q)WAP to Check for Armstrong Number

        // Console.WriteLine("Enter the number to check for armstrong number");
        // string number_string=Console.ReadLine();
        // int sum=0;
        // int len=number_string.Length;
        // int number=Convert.ToInt32(number_string);
        // int duplicate=number;

        // while (number > 0)
        // {
        //     int rem=number%10;
        //     sum+=Convert.ToInt32(Math.Pow(rem,len));
        //     number/=10;
        // }

        // if (sum == duplicate)
        // {
        // Console.WriteLine($"Given number {duplicate} is Armstrong number");
            
        // }
        // else
        // {
            
        // Console.WriteLine($"Given number {duplicate} is not Armstrong number");
        // }

        // ----------------------------------------------------------------------------------------------------------
      
        // Q) Program to print armstrong numbers from n1 to n2

             int flag=0;
             Console.WriteLine("Enter Starting Range to check for armstrong number");
             int number1=Convert.ToInt32(Console.ReadLine());
             

             Console.WriteLine("Enter Ending Range to check for armstrong number");
             int number2=Convert.ToInt32(Console.ReadLine());
             
             for(int i = number1; i <= number2; i++)
        {
            int duplicate=i;
            int number=i;
            string number_str=Convert.ToString(i);
            int len=number_str.Length;

            int sum=0;

             while (number > 0)
             {
                 int rem=number%10;
                 sum+=Convert.ToInt32(Math.Pow(rem,len));
                 number/=10;
             }

             if (sum == duplicate)
             {
             Console.WriteLine($"Given number {duplicate} is Armstrong number");
             flag=1;


             }
        }
        if (flag == 0)
        {
            
             Console.WriteLine($"There is no any Armstrong number.");
        }




    }
}