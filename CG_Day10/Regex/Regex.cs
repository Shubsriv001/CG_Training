using System;
using System.Text.RegularExpressions;
class RegexExample
{
    public static void Main(string[] args)
    {
        //Here @ represent that this is not the normal text this belongs  to the Regex.....
        //\d- this  will find wheather the sentence have digit in it, if yes return true else false..

        // string sentence="abc123"; //1)
        string pattern=@"\d";

        string sentence="123_123"; //2)


        bool a=Regex.IsMatch(sentence,pattern);
        Console.WriteLine(a);
    }
}