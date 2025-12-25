using System;
using Christmas;

class Program
{
    public static void Main(string[] args)
    {
        Employee emp=new Employee(1001,20000.00,"Max","Manager","Banglore");

        Console.WriteLine();
        Console.WriteLine("Below is the Original data:");
        Console.WriteLine(emp[0]);
        Console.WriteLine(emp[1]);
        Console.WriteLine(emp[2]);
        Console.WriteLine(emp[3]);
        Console.WriteLine(emp[4]);
        Console.WriteLine(emp[5]);
        Console.WriteLine();

        emp[0]=10002;
        Console.WriteLine("Below is the updated data:");
        Console.WriteLine(emp[0]);
        Console.WriteLine(emp[1]);
        Console.WriteLine(emp[2]);
        Console.WriteLine(emp[3]);
        Console.WriteLine(emp[4]);
        Console.WriteLine(emp[5]);

        Console.WriteLine();


        Console.WriteLine("Data Access by name:");

        Console.WriteLine(emp["Eno"]);

        
        Console.WriteLine("Below is the updated data Using name :");
        emp["ENO"]=10000055;
        Console.WriteLine(emp["Eno"]);


    }
}