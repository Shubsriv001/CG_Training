using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class function
{

// --------------------------------------------------------------------------------------------

    // Name Argument:- we can change the order while passing the value to the function

    // public void Person(string name, int age, string city)
    // {
    //     Console.WriteLine($"Name {name} Age {age} and city {city}");
    // }

// ---------------------------------------------------------------------------------------------

    // Default Parameter

    // public void Person(string name,int age, string city="varanasi")
    // {
        
    //     Console.WriteLine($"Name {name} Age {age} and city {city}");

    // }

// ---------------------------------------------------------------------------------------------
    
    // Use of param-> use to take multiple input as argument while calling the function

    // param should be always at the last
     public void add_num(params int[] nums)
    {
        int sum=0;
        foreach(int n in nums)
        {
            sum+=n;
        }

        // Console.WriteLine(string.Join(" ",week));
        Console.WriteLine(sum);
        Console.WriteLine(a);
    }
        

// ----------------------------------------------------------------------------
//-----------------------------Pass By value and Pass by Value--------------------------

// 1) Pass By Reference:- When we want to change the value parmanently.

// public void increase_ten(ref int a)
//         {
//             a+=10;
//         }

// ----------------------------------------------------------------------------------------------
// Example of out this is use to store the value and return it

// 1) Example

    // public static void Divide(int a, int b, out int quotient, out int remainder)
    // {
    //     quotient = a / b;
    //     remainder = a % b;
    // }

// ----------------------------------------------------------------------------------------------

// 2) Example

//   public static void GetResult(int marks, out string grade)
//     {
//         if (marks >= 60)
//             grade = "Pass";
//         else
//             grade = "Fail";
//     }


// ----------------------------------------------------------------------------------------------

// In Methods
// static void show(in int x)
// {
//     Console.WriteLine(x);
// }





// ----------------------------------------------------------------------------------------------
    public static void Main(string[] args)
    {
        //creating object on the class
        function fun_obj=new function();

// --------------------------------------------------------------------------------------------

        // Named Argument Object:

        // fun_obj.Person(age:21,name:"shubhanshu", city:"varanasi");

// --------------------------------------------------------------------------------------------

        // Default Parameter:

        // fun_obj.Person(age:21,name:"shubhanshu", city:"varanasi");
        // fun_obj.Person(age:21,name:"hjk");

// ---------------------------------------------------------------------------------------------

        // below is the example of paran argument
        // fun_obj.weeks("sunday","monday");


// ------------------------------------------------------------------------------------------------

    // BELOW is the Example of foreach Loop Accessing all the element of the array.

    // int []arr={1,2,3,4,5,6,7,8,9,10};
    // foreach(int a in arr)
    //     {
    //         Console.WriteLine(a);
    //     }

    // string Name="Shubhanshu";
    // foreach(char a in Name)
    //     {
    //         Console.WriteLine(a);
    //     }
// ----------------------------------------------------------------------------------------------
 
//  Calling the param function using object of the class and passing multiple value 

    // fun_obj.add_num(1,2,3,4,5,6,7,8,9,10);

    // If we want to pass the array to the param we need to pass it as a single array variable
    int []brr={1,2,3,4,5,6,7,8,9,10};

    fun_obj.add_num(brr);




// ----------------------------------------------------------------------------------------------



// 1) Pass By Value function calling

// int x=10;
// fun_obj.increase_ten(ref x);
// Console.WriteLine(x);

// --------------------------------------------------------------------------------------------
// ---------------------------calling out function----------------------------------- 

// 1) Example

        // int q, r; 

        // function.Divide(10, 3, out q, out r);

        // Console.WriteLine("Quotient = " + q);
        // Console.WriteLine("Remainder = " + r);

// --------------------------------------------------------------------------------------------

// 2) Example

//   string result;
//         function.GetResult(75, out result);
//         Console.WriteLine(result);

// --------------------------------------------------------------------------------------------


// -----------------------------------------In Method Calling---------------------------------


// int num = 50;
// function.show(num);
// --------------------------------------------------------------------------------------------
    }
}