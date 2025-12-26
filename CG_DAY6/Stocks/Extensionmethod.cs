using System;

static class Extensions
{
    public static bool IsEven(this int num)
    {
        return num % 2 == 0;
    }
}

class Program
{
    static void Main()
    {
        int n = 10;
        Console.WriteLine(n.IsEven());
    }
}
