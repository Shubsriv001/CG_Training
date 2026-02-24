using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> data = new List<string>
        {
            "Ravi,87",
            "Kumar,98",
            "Arun,92"
        };

        var result = data.OrderByDescending(x => int.Parse(x.Split(',')[1])).Take(3).Select(x => x.Split(',')[0]).ToList();

        result.ForEach(Console.WriteLine);
    }
}