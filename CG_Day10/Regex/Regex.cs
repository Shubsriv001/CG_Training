using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
class RegexExample
{
    public static void Main(string[] args)
    {
        //Here @ represent that this is not the normal text this belongs  to the Regex.....
        //\d- this  will find wheather the sentence have digit in it, if yes return true else false..

        // string sentence="abc123"; //1)
        // string pattern=@"\d";
        // string sentence="123_123"; //2)

        // bool result=Regex.IsMatch(sentence,pattern); // this will return the boolean wheather the pattern is present in the sentence is not...

// ---------------------------------------------------------------------------------------------------------
        // string pattern=@"\d+"; // this will give 5000 as return in the value
        // string pattern=@"\d*"; // this will return the empty value bcz it checks at the start, it find zero occurence of digit so it won't check the rest of the string.
        // string sentence="Amount_5000"; //3)


        // Match m=Regex.Match(sentence,pattern);
        // Console.WriteLine(m.Value);

        // -------------------------------------------------------------------------------

        //  string sentence="10 20 30"; 
        //  string pattern=@"\d+";


        // MatchCollection matches=Regex.Matches(sentence,pattern);
        //     foreach (var item in matches)
        //     {
        // Console.WriteLine(item);
                
        //     }

// ------------------------------------------------------------------------------------------------------------------------------

    //  this will return all the character which is not a digit in the sentence.
        //  string sentence="10A20B30C"; 
        //  string pattern=@"\D";


        // MatchCollection matches=Regex.Matches(sentence,pattern);
        //     foreach (var item in matches)
        //     {
        // Console.WriteLine(item);
                
        //     }

// ------------------------------------------------------------------------------------------------------------------------------

        //  string sentence="10A20B30C"; 
        //  string pattern=@"\w";


        // MatchCollection matches=Regex.Matches(sentence,pattern);
        //     foreach (var item in matches)
        //     {
        // Console.WriteLine(item);
                
        //     }

        // Console.WriteLine();
        //      Match m=Regex.Match(sentence,pattern);
        // Console.WriteLine(m.Value);

// -------------------------------------------------------------------------------------------------

//  string sentence="10A20B30C!@_"; 
//          string pattern=@"\w"; // no any special character is allowed accept '_'


//         MatchCollection matches=Regex.Matches(sentence,pattern);
//             foreach (var item in matches)
//             {
//         Console.WriteLine(item);
                
//             }

//              Console.WriteLine();
//              Match m=Regex.Match(sentence,pattern);
//              Console.WriteLine(m.Value);




// ---------------------------------------------------------------------------------------------------


//  string sentence="10A20B30C!@_"; 
//          string pattern=@"\W";  // it will return all the special character


//              Console.WriteLine("From Matches");

//         MatchCollection matches=Regex.Matches(sentence,pattern);
//             foreach (var item in matches)
//             {
//         Console.WriteLine(item);
                
//             }
//                 Console.WriteLine();
//              Console.WriteLine("From Match");
//              Match m=Regex.Match(sentence,pattern);
//              Console.WriteLine(m.Value);


// ------------------------------------------------------------------------------------

//  string sentence="10A20B30C!@_ _0!\t"; 
//          string pattern=@"\W";  // it will return all the special character -W: Non Word Character


//              Console.WriteLine("From Matches");

//         MatchCollection matches=Regex.Matches(sentence,pattern);
//             foreach (var item in matches)
//             {
//         Console.WriteLine(item);
                
//             }
//              Console.WriteLine("From Match");
//              Match m=Regex.Match(sentence,pattern);
//              Console.WriteLine(m.Value);


// ----------------------------------------------------------------------------------------------------


//  string sentence="10A20B30C!@_ "; 
//          string pattern=@"\s";  // s:-look for white space tab, S:- look for all except white space tab,


//              Console.WriteLine("From Matches");

//         MatchCollection matches=Regex.Matches(sentence,pattern);
//             foreach (var item in matches)
//             {
//         Console.WriteLine(item);
                
//             }
//              Console.WriteLine("From Match");
//              Match m=Regex.Match(sentence,pattern);
//              Console.WriteLine(m.Value);

// ---------------------------------------------------------------------------------------------


//  string sentence="10A20B30C!@_abc _0!\t, file.txt "; 
//          string pattern=@"\.txt"; 


//              Console.WriteLine("From Matches");

//         MatchCollection matches=Regex.Matches(sentence,pattern);
//             foreach (var item in matches)
//             {
//         Console.WriteLine(item);
                
//             }
//              Console.WriteLine("From Match");
//              Match m=Regex.Match(sentence,pattern);
//              Console.WriteLine(m.Value);


// ---------------------------------------------------------------------------------------------------

// string sentence="?10A20B30C!@_abc _0!\t,c:\abc\file.txt?"; 
//          string pattern=@"\?";


//              Console.WriteLine("From Matches");

//         MatchCollection matches=Regex.Matches(sentence,pattern);
//             foreach (var item in matches)
//             {
//         Console.WriteLine(item);
                
//             }
//              Console.WriteLine("From Match"); // this checks the first occurence and return
//              Match m=Regex.Match(sentence,pattern);
//              Console.WriteLine(m.Value);


// -------------------------------------------------------------------------------------------------------


// string sentence="?10A20B30C!@_abc _0!\t,c:\abc\file.txt?Hello"; 
//         //  string pattern=@"lo$";
//          string pattern=@"Hello$"; // here dollar will check the value or the pattern is present at the end or not


//              Console.WriteLine("From Matches");

//         MatchCollection matches=Regex.Matches(sentence,pattern);
//             foreach (var item in matches)
//             {
//         Console.WriteLine(item);
                
//             }
//              Console.WriteLine("From Match"); // this checks the first occurence and return
//              Match m=Regex.Match(sentence,pattern);
//              Console.WriteLine(m.Value);


// --------------------------------------------------------------------------------------------------------------------------

// string sentence="Hello?10A20B30C!@_abc _0!\t,c:\abc\file.txt?"; 
//         //  string pattern=@"lo$";
//          string pattern=@"^Hello"; // here carat will check the value or the pattern is present at the start or not


//              Console.WriteLine("From Matches");

//         MatchCollection matches=Regex.Matches(sentence,pattern);
//             foreach (var item in matches)
//             {
//         Console.WriteLine(item);
                
//             }
//              Console.WriteLine("From Match"); // this checks the first occurence and return
//              Match m=Regex.Match(sentence,pattern);
//              Console.WriteLine(m.Value);




// --------------------------------------------------------------------------------------------------------------------------

// string sentence="Hello"; 
//         //  string pattern=@"lo$";
//          string pattern=@"^Hello$"; 


//              Console.WriteLine("From Matches");

//         MatchCollection matches=Regex.Matches(sentence,pattern);
//             foreach (var item in matches)
//             {
//         Console.WriteLine(item);
                
//             }
//              Console.WriteLine("From Match"); // this checks the first occurence and return
//              Match m=Regex.Match(sentence,pattern);
//              Console.WriteLine(m.Value);

// --------------------------------------------------------------------------------------------------------------------------



// --------------------------------------------------------------------------------------------------------------------------

        //     string sentence="Date:25-12-29"; 
        //  string pattern=@"(\d{4})-(\d{2})-(\d{2})"; 


        //      Console.WriteLine("From Matches");

        // MatchCollection matches=Regex.Matches(sentence,pattern);
        //     foreach (var item in matches)
        //     {
        // Console.WriteLine(item);
                
        //     }
        //      Console.WriteLine("From Match"); // this checks the first occurence and return
        //      Match m=Regex.Match(sentence,pattern);
        //      Console.WriteLine(m.Value);

// --------------------------------------------------------------------------------------------------------------------------
// -----------------------------------Split Mathod---------------------------------------------------------------------------------------

        //     string sentence="A,B;C"; 
        //  string pattern=@"[,;]"; 
// --------------------------------------------------------------------------------------------------------------------------


// --------------------------------------------------------------------------------------------------------------------------


        // string sentence = "Amount:5000";
        // string pattern = @"Amount:(?<value>\d+)";

        // // Console.WriteLine("From Matches");
        // // MatchCollection matches = Regex.Matches(sentence, pattern);
        // // foreach (Match item in matches)
        // // {
        // //     Console.WriteLine(item.Value);
        // // }

        // Console.WriteLine("From Match");
        // Match m = Regex.Match(sentence, pattern);
        // Console.WriteLine(m.Value);

// --------------------------------------------------------------------------------------------------------------------------
// -----------------------------------Grouped pattern---------------------------------------------------------------------------------------

// ?- this will represent the named argument.
//<>- this represent group name.
//()- using this we are specifying the group.
//Pattern:-@(?<year>\d{4}-(?<nonth>\d{2})-(?<date>\d{2}))


        // string pattern = @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";

        // // string sentence = "23-02-1992";
        // string sentence = "1992-02-23";
        // // string sentence = "1992-01-01";
        // Console.WriteLine();
        // Console.WriteLine("From Matches");
        // MatchCollection matches = Regex.Matches(sentence, pattern);
        // foreach (Match item in matches)
        // {
        //     Console.WriteLine(item.Value);
        // }


        // Console.WriteLine("From Match");

        // Match m = Regex.Match(sentence, pattern);

        // // Console.WriteLine(m.Groups["year"].Value);
        // // Console.WriteLine(m.Groups["month"].Value);

        // //thisis how we access the named group using index
        // Console.WriteLine(m.Groups[0].Value); // this will print the entire data 
        // // Console.WriteLine(m.Groups[1].Value); // this is inly print the year means 0- all, 1- for year, 2- month, 3- date

// --------------------------------------------------------------------------------------------------------------------------

// string input="apple";
// string pattern=@"a.."; // this will print a+ch-ch
// // string pattern=@"a...e"; // this will help to print the character between a+ch-ch-ch+e means three character between a and e

// MatchCollection m=Regex.Matches(input,pattern);
// foreach (Match mt in m)
// {
//  System.Console.WriteLine(mt);   
// }

// ------------------------------------------------------------------




// ---------------------------Return the valid emails-----------------------------------------------------------------------------------------------

string pattern=@"\b[\w.-]+@[\w-]+\.\w{2,}$\b";
            
List<string> Emails = new List<string>
{
    "john.doe@gmail.com.au",
    "alice_123@yahoo.in",
    "mark.smith@company.com",
    "support-abc@banking.co.in",
    "user.nametag@domain.org",
  "john.doe@gmail",            // Missing domain extension
    "alice@@yahoo.com",        // Double @
    "mark.smith@.com",         // Domain missing name
    "support@banking..com",    // Double dot in domain
    "user name@gmail.com",     // Space not allowed
    "@domain.com",             // Missing username
    "admin@domain",            // No top-level domain
    "info@domain,com",         // Comma instead of dot
    "finance#dept@corp.com",  
    "plainaddress"             // Missing @ and domain

};


foreach(string input in Emails)
        {
        if (Regex.IsMatch(input, pattern))
        {
            Console.WriteLine($"Valid Email:   {input}");
        }
        }
        }
        }
        