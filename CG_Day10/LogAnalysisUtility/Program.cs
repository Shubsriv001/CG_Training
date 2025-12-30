using System;
using System.Text.RegularExpressions;
using LogProcessing;
class Program
{
    public static void Main(string[] args)
    {
       LogParser logParser_obj=new LogParser();

        Console.WriteLine(); 
        Console.WriteLine("[TRC] Application started\n"+logParser_obj.IsValidLine("[TRC] Application started")); 
        Console.WriteLine("[ERR] Database connection failed\n"+logParser_obj.IsValidLine("[ERR] Database connection failed")); 
        Console.WriteLine("[INF] Application started\n"+logParser_obj.IsValidLine("[INF] Application started")); 
        Console.WriteLine("[WRN] Low memory warning\n"+logParser_obj.IsValidLine("[WRN] Low memory warning")); 
        Console.WriteLine("INF Application started\n"+logParser_obj.IsValidLine("INF Application started")); 
        Console.WriteLine("[INFO] Application started\n"+logParser_obj.IsValidLine("[INFO] Application started")); 
        Console.WriteLine("[ABC] Unknown message\n"+logParser_obj.IsValidLine("[ABC] Unknown message")); 
    
        Console.WriteLine(); 
        logParser_obj.SplitLogLine();
        
      Console.WriteLine( logParser_obj.RemoveEndOfLineText("Transaction completed successfully end-of-line456"));

        

    
    
    }
}