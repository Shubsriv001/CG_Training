using System;
using System.IO;
using System.Text;

namespace FileIO
{
    public class UserTextManager
    {
        public void WriteUserToFile(string name, int age)
        {
            using (StreamWriter writer = new StreamWriter("Userfile.txt"))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
            }
        }

        public string ReadUserFromFile()
        {
            Console.WriteLine("User Data Loaded:");
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader("Userfile.txt"))
            {
                string data;
                while ((data = reader.ReadLine()) != null)
                {
                    result.AppendLine(data);
                }
            }

            return result.ToString();
        }
    }
}
