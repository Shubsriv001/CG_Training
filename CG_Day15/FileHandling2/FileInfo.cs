using System;

class FileInfoClass
{
    public static void Main(string[] args)
    {
     FileInfo file = new FileInfo("sample.txt");

        if (!file.Exists)
        {
            using (StreamWriter writer = file.CreateText())
            {
                writer.WriteLine("Hello FileInfo Class");
            }
        }

        Console.WriteLine("File Name: " + file.Name);
        Console.WriteLine("File Size: " + file.Length + " bytes");
        Console.WriteLine("Created On: " + file.CreationTime);
    }
}