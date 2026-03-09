using System;
class Program
{
    public static void Main(string[] args)
    {
        Repository<string> obj=new Repository<string>();
        obj.Add();
        obj.GetAll();
    }
}