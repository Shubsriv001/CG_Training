// using System;
// using System.IO;

// class FileExample
// {


//      class User
//     {
//         public int Id;
//         public string? Name;
//     }

    //if the file is not created then it will create one else write in the same file
    // public static void Main(string[] args)
    // {
    //     string path = "data3.txt";

    //     // this is use to write the data into the file...
    //     File.WriteAllText(path, "Dreams inside dream");


    //     // this is use too read the data  from the file...
    //    string data= File.ReadAllText(path);

    //    Console.WriteLine(data);
    //     Console.WriteLine("Task completed");



// =======================//=========================//=============================

// -----------------------------StreamReader and Stream Writer------------------------
// This will read and write the file and automatically deallocate all the resources after the work is done.
// It load the data byte by byte not at once.


// using(StreamWriter writer=new StreamWriter("log.txt"))
//         {
//             writer.WriteLine("Application Started");
//             writer.WriteLine("Data Processed");
//             writer.WriteLine("Application Ended");
//         }

//         using(StreamReader reader=new StreamReader("log.txt"))
//         {
//             string line;

//             while ((line = reader.ReadLine()) != null)
//             {
//                 Console.WriteLine(line);
//             }
//         }

// =======================================//=======================================//=================================
// User user=new User
// {
//   Id=1,
//   Name="Shubhanshu"  
// };



// using(StreamWriter writer=new StreamWriter("user.txt"))
//         {
//             writer.WriteLine(user.Id);
//             writer.WriteLine(user.Name);
//             user.Id=2;
//             user.Name="David";
        
//             writer.WriteLine(user.Id);
//             writer.WriteLine(user.Name);
//         }

//         Console.WriteLine("User Data Saved Successfully");


//  using(StreamReader reader=new StreamReader("user.txt"))
//         {
            // string line;

            // while ((line = reader.ReadLine()) != null)
            // {
            //     Console.WriteLine(line);

            // }
            // ========================//===============================//===============
        //     user.Id=Convert.ToInt32(reader.ReadLine());
        //     user.Name=(reader.ReadLine());
        // }
        // Console.WriteLine($"User ID is {user.Id} and name {user.Name}");


        // ============================Below is the example of binary Writer and the reader===========================


    // User user=new User{Id=2,Name="Bob"};

            //for creating and writing bin file
    // using(BinaryWriter writer=new BinaryWriter(File.Open("user.bin", FileMode.Create)))
    //     {
    //         writer.Write(user.Id);
    //         writer.Write(user.Name);

    //     }

    //     Console.WriteLine("Binary user data saved");

        // Reading Binary data

        // using(BinaryReader reader=new BinaryReader(File.Open("user.bin", FileMode.Open)))
        // {
        //     Console.WriteLine(reader.ReadInt32());
        //     Console.WriteLine(reader.ReadString());
        // }


//     }
// }
