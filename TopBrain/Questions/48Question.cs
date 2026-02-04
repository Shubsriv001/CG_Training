using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the radius of the circle");
        double radius=Convert.ToDouble(Console.ReadLine());
        double area=radius*radius*22/7;

        area=Math.Round(area,2);
        Console.WriteLine($"Area of the Circle is {area}");
    }
}