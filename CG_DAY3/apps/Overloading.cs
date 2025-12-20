using System;

class Overloading
{
    public void add(int a,int b)
    {
        Console.WriteLine(a+b);
    }
    // public void add(int a,int b, int c)
    // {
    //     Console.WriteLine(a+b+c);
    // }

    public void add(double a,double b)
    {
        Console.WriteLine(a+b);
    }

    public static void Main(string[] args)
    {
        
        Overloading overloading_obj=new Overloading();
        Console.WriteLine("Displaying two Integer data function");
        overloading_obj.add(1,2);
        // Console.WriteLine("Displaying Three Integer data function");
        // overloading_obj.add(15,25,50);
        Console.WriteLine("Displaying two double data function");
        
        // int the below code inter value get to 25.0 
        overloading_obj.add(100.2,25);
        overloading_obj.add(100.2,2.5);

    }
}