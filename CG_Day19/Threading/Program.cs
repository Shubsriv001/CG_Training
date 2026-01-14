using System;
using System.Threading;

class Program
{
    public static void Main(string[] args)
    {
    //     Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
    //     thread.Start("Hello from thread");
    // }

    // static void PrintMessage(object message)
    // {
    //     Console.WriteLine(message);


Thread work=new Thread(DoWork); // creating new thread and passing method name that have no patrameter 
work.Start(); // this line use to start the thread execution
Console.WriteLine("Main thread Continues...."); // this line will run as the execution start

    }

    static void DoWork() // this is the methode that is passed in to the thread
    {
        for(int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Work Thread: "+i);
            Thread.Sleep(5000);
        }
    }

}
