using System;
class Program
{
    public static void Main(string[] args)
    {
        //1)WAP to print the Hello World message
        // Console.WriteLine("Hello World");

        // ---------------------------------------------

        //2)WAP to take number from the user and print it back
            // Console.WriteLine("Enter the number to print back:");
            // int num = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"number enterde by the user is :{num}");

        // --------------------------------------------------


        //3) WAP to read floating point number from the user

            // Console.WriteLine("Enter floating point number");
            // float float_number = Convert.ToSingle(Console.ReadLine());
            // Console.WriteLine($"floating number entered by the user is {float_number}");

        //---------------------------------------------------------------------------------------------

        //4)WAP to read a string from the user and print it back

            // Console.WriteLine("Enter the String :");
            // string entered_string = Console.ReadLine();
            // Console.WriteLine($"entered String is {entered_string}");

        //-----------------------------------------------------------------------------------------------
    
    
        //5)WAP to perform all the arithmatic operations
     
            //Console.WriteLine("Enter the number to perform arithmatic operations");
            //Console.WriteLine("Enter 1st number: ");

            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter 2nd number: ");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //int sum = number1 + number2;
            //Console.WriteLine($"sum of the entered number is {sum}");

            //int sub = number1 - number2;
            //Console.WriteLine($"subtraction of the entered number is {sub}");
            //int mul = number1 * number2;
            //Console.WriteLine($"product of the entered number is {mul}");
            //int divide = number1 / number2;
            //Console.WriteLine($"division of the entered number is {divide}");

        //--------------------------------------------------------------------------------------------
     
        //6)WAP to find the area of the circle
    
            //Console.WriteLine("Find area of circle");

            //Console.WriteLine("enter the radius of the circle");
            //float radius = Convert.ToSingle(Console.ReadLine());

            //float area = radius * radius * 22 / 7;

            //Console.WriteLine($"Area of the circle is {area}");

        //------------------------------------------------------------------------------------------------
   
        //7)WAP to find odd or even number
    
            //Console.WriteLine("Find Even and Odd number");

            //int input_number = Convert.ToInt32(Console.ReadLine());

            //if (input_number % 2 == 0)
            //{
            //    Console.WriteLine("entedrtd number is EVEN");
            //}
            //else
            //{
            //    Console.WriteLine("ODD numnber");
            //}

            //Console.WriteLine();

        //-------------------------------------------------------------------------------------------------
    
        //8)WAPto find whether the given number is positive negative or zero
    
            //Console.WriteLine("Enter the number to find the positive and negative or zero");

            //int nature_number = Convert.ToInt32(Console.ReadLine());

            //if (nature_number > 0)
            //{
            //    Console.WriteLine("Entered number is Positive");

            //}
            //else if (nature_number < 0)
            //{
            //    Console.WriteLine("Negative number");
            //}
            //else if (nature_number == 0)
            //{
            //    Console.WriteLine("Entered number is Zero");

            //}

            //Console.WriteLine();

        //------------------------------------------------------------------------------------------
    
        //9)WAP to find the greatest of two number
     
            //Console.WriteLine("Enter two number to find the greates among them");

            //Console.WriteLine("Enter 1st number: ");

            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter 2nd number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 == num2)
            //{
            //    Console.WriteLine("Enteredd number are Equal");
            //}
            //else if (num1 > num2)
            //{
            //    Console.WriteLine($"Number 2 is Greater than number 1{num2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Number 1 is greater than number 2 {num1}");
            //}

            //Console.WriteLine();

        //--------------------------------------------------------------------------------
    
        //10)WAP to find the greatest of the three number
   
            //Console.WriteLine("Enter three number to find the greatest among them");
            //Console.WriteLine("Enter 1st number: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter 2nd number: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter 3rd number: ");
            //int n3 = Convert.ToInt32(Console.ReadLine());

            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine($"Number 1 {n1} is greater then any other number");
            //}
            //else if (n2 > n1 && n2 > n3)
            //{
            //    Console.WriteLine($"Number 2 {n2} is greater then any other number");

            //}
            //else if (n3 > n1 && n3 > n2)
            //{
            //    Console.WriteLine($"Number 3 {n3} is greater then any other number");

            //}


        //--------------------------------------------------------------------------------------

        //-------------------------------------CASE STUDY--------------------------------------

        //11) WAP to check wheather the entered character is vowel or not

            //Console.WriteLine("Enter the character to check");

            //char character = Convert.ToChar(Console.ReadLine());

            //switch (character)
            //{
            //    case 'a':
            //        Console.WriteLine($"Entered character is vowel {character}");
            //        break;


            //    case 'e':
            //        Console.WriteLine($"Entered character is vowel {character}");
            //        break;

            //    case 'i':
            //        Console.WriteLine($"Entered character is vowel {character}");
            //        break;

            //    case 'o':
            //        Console.WriteLine($"Entered character is vowel {character}");
            //        break;

            //    case 'u':
            //        Console.WriteLine($"Entered character is vowel {character}");
            //        break;


            //    case 'A':
            //        Console.WriteLine($"Entered character is vowel {character}");
            //        break;

            //    case 'E':
            //        Console.WriteLine($"Entered character is vowel {character}");
            //        break;


            //    case 'I':
            //        Console.WriteLine($"Entered character is vowel {character}");
            //        break;

            //    case 'O':
            //        Console.WriteLine($"Entered character is vowel {character}");
            //        break;

            //    case 'U':
            //        Console.WriteLine($"Entered character is vowel {character}");
            //        break;


            //    default:
            //        Console.WriteLine("Not a Vowel.");
            //        break;
             //}

        //----------------------------------------------------------------------------------------------------

        //12) WAP to take the string from the user and change  it to upper case and find the length of the string

            //Console.WriteLine("Enter the String to convert to the Upper case and give the length of the string");
            //string name=Console.ReadLine();

            //string upper_string = name.ToUpper();

            //int len=upper_string.Length;

            //Console.WriteLine($"Original String Length: {len}");
            //Console.WriteLine($"Uppercase string: {upper_string}");



        //-----------------------------------------------------------------------------------------------------

        //13) WAP to  swap the number without using any third variable

            //Console.WriteLine("enter the first number");
            //int number1=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter the second number");

            //int number2=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Before Swap: a= {number1}, b={number2}");

            //number1 = number1 + number2;

            //number2 = number1 - number2;

            //number1 = number1 - number2;

            //Console.WriteLine($"After swap: a= {number1}, b={number2}");

        //----------------------------------------------------------------------------------------
        
    }
}