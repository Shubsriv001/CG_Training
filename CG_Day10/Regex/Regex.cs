using System;
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

            string sentence="Date:25-12-29"; 
         string pattern=@"(\d{4})-(\d{2})-(\d{2})"; 


             Console.WriteLine("From Matches");

        MatchCollection matches=Regex.Matches(sentence,pattern);
            foreach (var item in matches)
            {
        Console.WriteLine(item);
                
            }
             Console.WriteLine("From Match"); // this checks the first occurence and return
             Match m=Regex.Match(sentence,pattern);
             Console.WriteLine(m.Value);

// --------------------------------------------------------------------------------------------------------------------------

    }
}