using System;
using FileIO;
using System.Security.AccessControl;
using System.Text;
using System.Diagnostics;
class Program
{
    public static void Main(string[] args)
    {
    //     ----------------------Task 1 object----------------------
       UserTextManager obj=new UserTextManager();
       obj.WriteUserToFile("shubhanshu",21); 
       string data=obj.ReadUserFromFile();
       Console.WriteLine(data);



    // ----------------------Task 2 object----------------------
       UserBinaryManager Bobj=new UserBinaryManager();
       Bobj.SaveUserBinary(101,"Bob");
       
       Console.WriteLine(Bobj.LoadUserBinary());

    // ----------------------Task 3 object----------------------

    FileSystemManager FMobj=new FileSystemManager();
    Console.WriteLine("Enter Folder name");
    string folder=Console.ReadLine();
    Console.WriteLine("Enter File name");
    string file=Console.ReadLine();

    FMobj.CreateDirectory(folder);
    FMobj.CreateFile(file);
    Console.WriteLine(FMobj.CheckFileExists(file));
    




    }
}