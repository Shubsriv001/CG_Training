// using System;
// using System.Data;
// using System.Diagnostics;
// class Debugginh
// {
//     public static void Main(string[] args)
//     {
//         // Trace.Listeners.Add(new ConsoleTraceListener()); this will print the value in the console
//         Trace.WriteLine("Application Started");// this line help in print in debug console

//         int a=10;
//         int b=0;
//         try
//         {
//             int result=a/b;
//             Console.WriteLine(result);
//         }
//         catch(Exception ex)
//         {
//             Trace.WriteLine("Exception occured: "+ ex.Message);
//         }

//         Trace.WriteLine("Application Ended");

//     }
// }