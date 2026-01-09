using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

[Serializable]
    public class User1
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
class SerialClass
{
    // Serialization in C# is the process of converting an object into a format
    // that can be stored or transmitted, such as a file, memory stream, or network stream.


    public static void Main(string[] args)
    {
        User1 user = new User1
        {
            Id = 1,
            Name = "Alice"
        };

        // // string json = JsonSerializer.Serialize(user);
        // // File.WriteAllText("user.json", json);
        // // Console.WriteLine("User Serialization Successfully");

        // // below is the code to read the json file data.
        // string json = File.ReadAllText("user.json");
        // Console.WriteLine(json);

        // // below is the code for Deserialization
        // User loadUser = JsonSerializer.Deserialize<User>(json)!;
        // Console.WriteLine($"User : {loadUser.Id} {loadUser.Name}");



        //below is the code for XML serialization

        XmlSerializer serializer = new XmlSerializer(typeof(User1));
        using (FileStream fs = new FileStream("user.xml", FileMode.Create))
        {
            serializer.Serialize(fs, user);
        }
            Console.WriteLine("XML Serialized");
    }
    }