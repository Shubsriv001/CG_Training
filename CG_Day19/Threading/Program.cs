// using System;
// using System.Globalization;
// using System.Threading;
// using System.Threading.Tasks;
// using System.IO;
using System.Diagnostics;


// class Program
// {
    // public static async Task Main(string[] args)
    // {
    //     Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
    //     thread.Start("Hello from thread");
    // }

    // static void PrintMessage(object message)
    // {
    //     Console.WriteLine(message);


// Thread work=new Thread(DoWork); // creating new thread and passing method name that have no patrameter 
// work.Start(); // this line use to start the thread execution
// Console.WriteLine("Main thread Continues...."); // this line will run as the execution start
//     }

    // static void DoWork() // this is the methode that is passed in to the thread
    // {
    //     for(int i = 1; i <= 5; i++)
    //     {
    //         Console.WriteLine("Work Thread: "+i);
    //         Thread.Sleep(1000); //this will work only on the loop have no relation with  the above work thread... 
    //     }


//====================//=============== Below is the code for prallel===============//================

            // Parallel.For(0, 5, i => // here for is not the loop this is the static function present in the Parallel
            //         {
            //             Console.WriteLine($"Process item {i}");
            //              });


//=======================///================================//================================//========================= 
  
//   int []numbers=new int[10]; 
//   for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i]=i+1;
//         }
//                 int sum=0;
        //         Parallel.For(0, numbers.Length, i =>
        //         {
        //             sum+=numbers[i];
        //         });

        //         Console.WriteLine("sum: "+sum);

// ==============================//==============================//============================//===========================


        // Parallel.For(0, numbers.Length, () => 0, (i, loopState, localSum) =>
        // {
        //    return localSum+numbers[i];
        // }, localSum =>
        // {
        //     Interlocked.Add(ref sum, localSum);
        // });
        // System.Console.WriteLine("Sum: "+sum);


// =========================//=============Async Await====================//=====================//======

    // async Task<int> GetDataAsync()
    //     {
    //         await Task.Delay(1000);// thread is not blocked...
    //         // Thread.Sleep(3000);// thread is blocked for 3 sec...
    //         return 42;
    //     }
    //  Console.WriteLine(await GetDataAsync());

//========================//===========================//============================//==================
// static async Task Main()
//     {

        // Console.WriteLine("Start reading file..");
        // string content=await File.ReadAllTextAsync("data.txt");
        // Console.WriteLine("File content: "+ content);
        // Console.WriteLine("End of the program");    

//     }

// }

// ===========================//================================//===============================

// using System;
// using System.Diagnostics;
// using System.Runtime.ConstrainedExecution;

// class Program
// {
//     static void Main()
//     {
//         Process currentProcess=Process.GetCurrentProcess();
//         System.Console.WriteLine("Current Process ID: "+ currentProcess.Id);
//         System.Console.WriteLine("Process Name: "+currentProcess.ProcessName);
//         System.Console.WriteLine("Process Start Time: "+currentProcess.StartTime);
//         System.Console.WriteLine("Process Threads: "+currentProcess.Threads);
//         System.Console.WriteLine("Total Processor Time: "+currentProcess.TotalProcessorTime);
//     }
// }


// ===================================//===============================//=================================

// using System;
// using System.Threading;

// class Program
// {
//     static void Main()
//     {
//         // Create a new thread
//         Thread worker = new Thread(DoWork);

//         // Start the thread
//         worker.Start(); // this is not call the thread as it call it may schedule the task totaly depends on the priority of the task......

//         Console.WriteLine("Main thread continues...");

//         // Optional: Wait for worker thread to finish
//         worker.Join();
//         Console.WriteLine("Main thread finished");
//     }

//     static void DoWork()
//     {
//         for (int i = 1; i <= 5; i++)
//         {
//             Console.WriteLine("Worker thread: " + i);
//             Thread.Sleep(500); // Simulate work
//         }
//     }
// }


// ==============================//===============//=======================//========================//=========================

// using System.Diagnostics;
// class Program
// {
//     static void Main()
//     {
//         // Process.Start("notepad.exe");
//         // Process.Start("cmd.exe");
//     }
// }
    
// ==============================//===============//=======================//========================//=========================

// using System;
// using System.Threading;

// class Program
// {
//     static int counter=0;
//     static void Main()
//     {
//         Thread t1=new Thread(Increament);
//         Thread t2=new Thread(Increament);

//         t1.Start();
//         t1.Join(); // it will help t1 to complete the task before starting the next.... 

//         t2.Start();
//         t2.Join();

//         Console.WriteLine("Counter Value is: "+counter);

//        static void Increament()
//         {
//             for(int i = 0; i < 1000000; i++)
//             {
//             counter+=1;
                
//             }
//         }

//     }
// }

// ==============================//===============//=======================//========================//=========================

// using System.Threading;

// class Program
// {

// static object lockObj=new object();

//     static int counter=0;
//     static void Main()
//     {
//         Thread t1=new Thread(Increament);
//         Thread t2=new Thread(Increament);

//         t1.Start();
//         t2.Start();

//         t1.Join();
//         t2.Join();

//         Console.WriteLine("Counter Value is: "+counter);

//        static void Increament()
//         {
//             for(int i = 0; i < 100000; i++)
//             {
//                 lock (lockObj)
//                 {
                    
//             counter+=1;
//                 }
                
//             }
//         }

//     }
// }

// ==============================//===============//=======================//========================//=========================


using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // try
        // {
        //     Task t = Task.Run(() => throw new Exception("Task error"));
        //     t.Wait();
        // }
        // catch (AggregateException ex)
        // {
        //     Console.WriteLine(ex.InnerExceptions[0].Message);
        // }


// ========================//====================//=================//
//Below is the exmple of combining task uaing the function "whenall" and "continuewith"

        Task  t1=Task.Run(()=>System.Console.WriteLine("Task 1"));
        Task  t2=Task.Run(()=>System.Console.WriteLine("Task 2"));

        Task.WhenAll(t1,t2).ContinueWith(t=>System.Console.WriteLine("All tasks completed")).Wait();
    }
    

}
