// using System;

// class FileInfoClass
// {
//     // this method is used for medium length file 
//     public static void Main(string[] args)
//     {
//      FileInfo file = new FileInfo("sample.txt");

//         if (!file.Exists)
//         {
//             using (StreamWriter writer = file.CreateText())
//             {
//                 writer.WriteLine("Hello FileInfo Class");
//             }
//         }
//         else
//         {
//             using (StreamWriter writer = file.CreateText())
//             {
//                 writer.WriteLine("Hello FileInfo Class this text is cteated using FileInfo");
//             }
            
//         }

//         Console.WriteLine("File Name: " + file.Name);
//         Console.WriteLine("File Size: " + file.Length + " bytes");
//         Console.WriteLine("Created On: " + file.CreationTime);
//         Console.WriteLine("Created On: " + file.LastWriteTime);

//     }
// }