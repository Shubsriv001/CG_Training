using System;

class function
{

    // Name Argument:- we can change the order while passing the value to the function

    // public void Person(string name, int age, string city)
    // {
    //     Console.WriteLine($"Name {name} Age {age} and city {city}");
    // }


    // Default Parameter

    public void Person(string name,int age, string city="varanasi")
    {
        
        Console.WriteLine($"Name {name} Age {age} and city {city}");
    }



    public static void Main(string[] args)
    {
        function fun_obj=new function();

        // Named Argument Object
        // fun_obj.Person(age:21,name:"shubhanshu", city:"varanasi");



         // Default Parameter

        fun_obj.Person(age:21,name:"shubhanshu", city:"varanasi");
        fun_obj.Person(age:21,name:"hjk");

    }
}