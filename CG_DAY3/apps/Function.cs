using System;

class function
{

    // Name Argument:- we can change the order while passing the value to the function

    // public void Person(string name, int age, string city)
    // {
    //     Console.WriteLine($"Name {name} Age {age} and city {city}");
    // }


    // Default Parameter

    // public void Person(string name,int age, string city="varanasi")
    // {
        
    //     Console.WriteLine($"Name {name} Age {age} and city {city}");

    // }




        // Use of param-> use to take multiple input as argument while calling the function

    //         public void weeks(params string[] week)
    // {
    //     Console.WriteLine(string.Join(" ",week));
    // }
        

    public static void Main(string[] args)
    {
        //creating object on the class
        function fun_obj=new function();

        // Named Argument Object:
        // fun_obj.Person(age:21,name:"shubhanshu", city:"varanasi");

        // Default Parameter:

        // fun_obj.Person(age:21,name:"shubhanshu", city:"varanasi");
        // fun_obj.Person(age:21,name:"hjk");

        // below is the example of paran argument
        // fun_obj.weeks("sunday","monday");


    // BELOW is the Example of foreach Loop Accessing all the element of the array.

    // int []arr={1,2,3,4,5,6,7,8,9,10};
    // foreach(int a in arr)
    //     {
    //         Console.WriteLine(a);
    //     }

    string Name="Shubhanshu";
    foreach(char a in Name)
        {
            Console.WriteLine(a);
        }





    }
}