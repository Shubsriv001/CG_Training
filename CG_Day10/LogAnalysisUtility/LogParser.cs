
using System;
using System.Text.RegularExpressions;
namespace LogProcessing
{
    class LogParser
    {

// 1)

    public bool IsValidLine(string text)
{
    bool b=Regex.IsMatch(text, @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]");
            return b;
}

// ---------------------------------------------------------------------------------------------------------

// 2)

   public void SplitLogLine()
{
    Console.WriteLine("Enter String text");
    string text = Console.ReadLine();

    string pattern = @"(<====>|<\*\*\*>|<\^\*>)";
    string[] arr = Regex.Split(text, pattern);

    Console.WriteLine("[");
    foreach (string s in arr)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine("]");
}

// ---------------------------------------------------------------------------------------------
// 3)

        public string RemoveEndOfLineText(string line)
        {
           string result = Regex.Replace(line, @"end-of-line+\d+", "");
            return result;
        }
   

    // ---------------------------------------------------------------------------------------------------------------






    }}
