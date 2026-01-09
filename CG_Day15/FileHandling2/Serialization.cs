using System;
using System.IO;
using System.Text.Json;

class SerialClass
{
    // Serialization in C# is the process of converting an object into a format
    // that can be stored or transmitted, such as a file, memory stream, or network stream.

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public static void Main(string[] args)
    {
        User user = new User
        {
            Id = 1,
            Name = "Alice"
        };

        // string json = JsonSerializer.Serialize(user);
        // File.WriteAllText("user.json", json);
        // Console.WriteLine("User Serialization Successfully");

        // below is the code to read the json file data.
        string json = File.ReadAllText("user.json");
        Console.WriteLine(json);

        // below is the code for Deserialization
        User loadUser = JsonSerializer.Deserialize<User>(json)!;
        Console.WriteLine($"User : {loadUser.Id} {loadUser.Name}");
    }
}
