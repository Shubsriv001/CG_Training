using System;
using System.IO;
using System.Text;

namespace FileIO
{


    // -------------Task 1---------------------------------------------------------------
    public class UserTextManager
    {
        private string filePath="Userfile.txt";
        public void WriteUserToFile(string name, int age)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
            }
        }

        public string ReadUserFromFile()
        {
            Console.WriteLine("User Data Loaded:");
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string? data;
                while ((data = reader.ReadLine()) != null)
                {
                    result.AppendLine(data);
                }
            }

            return result.ToString();
        }
    }


// -------------------Task 2----------------------------------------------------------------------------


    public class UserBinaryManager
    {
        private string filePath="Userfile.bin";

        public void SaveUserBinary(int id, string name)
        {
            using(BinaryWriter writer=new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(id);
                writer.Write(name);
            }
        }


        public string LoadUserBinary()
        {
                Console.WriteLine("User Loaded:");

            using(BinaryReader reader=new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int id=reader.ReadInt32();
                string name=reader.ReadString();
              return $"ID: {id}, Name: {name}";
            }
        }

    }


// -------------------Task 3----------------------------------------------------------------------------

public class FileSystemManager{
    private string baseDirectory;

public void CreateDirectory(string folderName)
        {
            Directory.CreateDirectory(folderName);
            if (Directory.Exists(folderName))
            {
                
                Console.WriteLine("Directory Created");
            }
        
        }

    public void CreateFile(string fileName)
        {
            File.Create(fileName);
            if (File.Exists(fileName))
            {
                
            Console.WriteLine("File Created");
            }
           
 
        }


        public bool CheckFileExists(string fileName)
        {
                FileInfo fileInfo=new FileInfo(fileName);
                
            return fileInfo.Exists;
            
        }
}

}
