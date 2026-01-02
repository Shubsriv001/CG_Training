using System;
class Linq
{
    public static void Main(string[] args)
    {
        
        int []number={1,2,3,4,5,6,7,8,9};
        
        var evenNumber=number.Where(n=> n%2==0);
       Console.WriteLine("type of: "+evenNumber.GetType());


       System.Console.WriteLine("Even Numbers are:");

       foreach(var n in evenNumber)
        {
            Console.WriteLine(n);
        }

    }
}