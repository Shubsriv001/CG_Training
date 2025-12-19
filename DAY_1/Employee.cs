using System;
namespace DAY_1;

    class Employee
{
    int Id;
    string Name="";
    string Dept=string.Empty;
    float Salary;
    string Gender="";


    public void AcceptDetails()
    {
        Console.WriteLine("Enter Employee Id: ");
        Id=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Employee name: ");
        Name=Console.ReadLine();

        Console.WriteLine("Enter Employee Dept: ");
        Dept=Console.ReadLine();

        Console.WriteLine("Enter Employee salary: ");
        Salary=Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Enter Employee gender: ");
        Gender=Console.ReadLine();

    }
    public void display()
    {
        Console.WriteLine();
        Console.WriteLine("Employee Data  Are: ");
        Console.WriteLine("---------------------------");

        // This is one of the way to print the value using String interpolation
         // Console.WriteLine($"Employee Name: {Name}");

        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee Dept: " + Dept);
        Console.WriteLine("Employee Salary: " + Salary);
        Console.WriteLine("Employee Gender: " + Gender);
        
    }

}


