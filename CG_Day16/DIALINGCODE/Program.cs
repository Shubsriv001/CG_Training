using System;
using System.Collections.Generic;
using DialingCodesApp;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        var emptyDict = DialingCodes.GetEmptyDictionary();
                Console.WriteLine("Task 1 Count of the elements in the dictionary is: "+emptyDict.Count);

        

        // Task 2
        var existingDict = DialingCodes.GetExistingDictionary();
                Console.WriteLine("Task 2");

        foreach(var i in existingDict)
        {
            Console.WriteLine(i);
        }

        // Task 3
        var japanDict = DialingCodes.AddCountryToEmptyDictionary(81, "Japan");
        Console.WriteLine("Task 3");
        foreach(var i in japanDict)
        {
            Console.WriteLine(i);
        }
        // Task 4
                Console.WriteLine("Task 4");

        DialingCodes.AddCountryToExistingDictionary(existingDict, 44, "United Kingdom");
         foreach(var i in existingDict)
        {
            Console.WriteLine(i);
        }

        // Task 5
                Console.WriteLine("Task 5");

        string country = DialingCodes.GetCountryNameFromDictionary(existingDict, 91);
        Console.WriteLine(country);

        // Task 6
                Console.WriteLine("Task 6");

        bool exists = DialingCodes.CheckCodeExists(existingDict, 55);
        Console.WriteLine(exists);

        // Task 7
                Console.WriteLine("Task 7");

        DialingCodes.UpdateDictionary(existingDict, 91, "Republic of India");
         foreach(var i in existingDict)
        {
            Console.WriteLine(i);
        }

        // Task 8
                Console.WriteLine("Task 8");

        DialingCodes.RemoveCountryFromDictionary(existingDict, 1);
         foreach(var i in existingDict)
        {
            Console.WriteLine(i);
        }

        // Task 9
                Console.WriteLine("Task 9");

        string longest = DialingCodes.FindLongestCountryName(existingDict);
        Console.WriteLine(longest);
    }
}
