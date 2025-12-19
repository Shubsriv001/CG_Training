using System;

namespace DAY_1;

class Calculator
{
    int number1;
    int number2;
    public void add()
    {
        Console.WriteLine("Enter the Data To Calculate the sum");

        Console.WriteLine("Enter number 1: ");
        number1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        number2=Convert.ToInt32(Console.ReadLine());

        int result=number1+number2;
        Console.WriteLine($"Sum of the number is {result}");
        Console.WriteLine();

    }

    public void sub()
    {
        Console.WriteLine("Enter the Data To Calculate the Subtraction");

         Console.WriteLine("Enter number 1: ");
        number1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        number2=Convert.ToInt32(Console.ReadLine());

         int result=number1-number2;
        Console.WriteLine($"Subtraction of the number is {result}");
        Console.WriteLine();
    }
    public void mul()
    {
        Console.WriteLine("Enter the Data To Calculate the Multiplication");

        Console.WriteLine("Enter number 1: ");
        number1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        number2=Convert.ToInt32(Console.ReadLine());

         int result=number1*number2;
        Console.WriteLine($"Multiplication of the number is {result}"); 
        Console.WriteLine();
    }
    public void div()
    {
        Console.WriteLine("Enter the Data To Calculate the Division");

        Console.WriteLine("Enter number 1: ");
        number1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        number2=Convert.ToInt32(Console.ReadLine()); 

         int result=number1/number2;
        Console.WriteLine($"Division of the number is {result}");
        Console.WriteLine();
    }
    public void Remainder()
    {
        Console.WriteLine("Enter the Data To Calculate the Remainder");

        Console.WriteLine("Enter number 1: ");
        number1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        number2=Convert.ToInt32(Console.ReadLine()); 

         int result=number1%number2;
        Console.WriteLine($"Remainder of the number is {result}");
        Console.WriteLine();
    }
   
}
