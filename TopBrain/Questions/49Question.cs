using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the Feet:");
        double ft=Convert.ToDouble(Console.ReadLine());
        double Cm=ft*30.48;
        Cm=Math.Round(Cm,2);
        Console.WriteLine(ft + " feet in Centimeter is " + Cm + " cm");
    }
}