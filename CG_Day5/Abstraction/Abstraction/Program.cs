// using System;

// // class Abstraction
// // {
        
// //     interface IPrintable
// // {
// //     // void Print();
// //     // void Scan();
// //     // int count();
// // }

// // class Report : IPrintable
// // {
// //     public void Print()
// //     {
// //         Console.WriteLine("Printing report");
// //     }
// // }


// // public static void Main(string[] args)
// //     {
// //         Report report_obj=new Report();






//         // ---------------------------------------Explicit Interface-------------------------------

// using System;

// interface ILogger
// {
//     void Log();
// }

// interface INotifier
// {
//     void Log();
// }

// class FileLogger : ILogger, INotifier
// {
//     void ILogger.Log()
//     {
//         Console.WriteLine("Logging to file via ILogger");
//     }

//     void INotifier.Log()
//     {
//         Console.WriteLine("Logging to notification via INotifier");
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         FileLogger file_obj = new FileLogger();

//         ILogger logger = file_obj;
//         logger.Log();

//         INotifier notifier = file_obj;
//         notifier.Log();
//     }
// }
