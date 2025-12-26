using System;

class Program
{
    public string CleanseAndInvert(string input)
    {
        int count=0;
        string reverse="";
        if (input.Length < 6 || input=="")
        {
            return "Invalid Input";
        }

        input = input.ToLower();
        string result = "";

        foreach (char c in input)
        {
            if ((int)c % 2 != 0)
            {
                result += c;
                count++;
            }
            else
            {
                continue;
            }
           
        
        }
        for(int i = result.Length-1; i >= 0; i--)
        {
            reverse+=result[i];
        }
        
        return reverse;
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine("Please Enter the Word:");
        string word = Console.ReadLine();
        string result2=p.CleanseAndInvert(word);
        string result3="";
        int len2=result2.Length;
        for(int i = 0; i < len2; i++)
        {
            if (i % 2 == 0)
            {
                result3 += result2[i].ToString().ToUpper();
            }
            else
            {
                result3 += result2[i].ToString();
            }
        }
        result3.Reverse();
        Console.WriteLine("The generated key is: " + result3);
    }
}
