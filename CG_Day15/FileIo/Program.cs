using System;
using FileIO;
using System.Security.AccessControl;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
       UserTextManager obj=new UserTextManager();
       obj.WriteUserToFile("shubhanshu",21); 
       string data=obj.ReadUserFromFile();
       Console.WriteLine(data);
    }
}