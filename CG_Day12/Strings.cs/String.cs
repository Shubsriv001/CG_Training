using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
class String
{
    public static void Main(string[] args)
    {
        StringBuilder sb=new StringBuilder();

        // ------------------------------------------------------------------------------------

        // sb.Append("Hello").Append("apple");
        // sb.Append(" ");
        // sb.Append("World");
        // sb.AppendLine("Line"); // adds one line after adding the text
        // sb.Insert(0,"start");// insert text at the index
        // sb.Remove(0,5); // remove from index 0 to 5 in which last index is not inclusive.
        // sb.Replace("Hello","apple");
        // sb.Clear();
        //    Console.WriteLine(sb[0]);

        // Console.WriteLine(sb.ToString());

        // ------------------------------------------------------------------------------------

        // Console.WriteLine("before memory "+GC.GetTotalMemory(false));

        //     for(int i = 0; i < 10000; i++)
        //     {
        //         sb.Append(i);
        //     }
        //     string result=sb.ToString();


        // Console.WriteLine("after memory "+GC.GetTotalMemory(false));

        // --------------------------------------------------------------------------------
        
// StringBuilder sb1=new StringBuilder("Hello");
// StringBuilder sb2=new StringBuilder("Hello");
// // StringBuilder sb3=sb2;
// Console.WriteLine(sb1==sb2);// this checks Reference after creating the new object the address on the each object get the new memory address...
// Console.WriteLine(sb1.Equals(sb2)); // this checks value of both the object..

// System.Console.WriteLine();

// string a="Apple";
// string b="Apple";

// System.Console.WriteLine(a.Equals(b));
// System.Console.WriteLine(a==b);

// Console.WriteLine(object.ReferenceEquals(sb1, sb2));



// ----------------------------------------------------------

System.Console.WriteLine(DateTime.Today);


// Common Properties
// DateTime now = DateTime.Now;
// int year=now.Year;
// int month=now.Month;
// int day= now.Day;
// int hour=now.Hour;
// int min=now.Minute;
// int sec=now.Second;


    }
    }