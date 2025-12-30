//    FileStream file = null;
// try
// {
//     file = new FileStream("data.txt", FileMode.Open);
//     // Perform file operations
//     int data = file.ReadByte();
//     Console.WriteLine("First byte: " + data);
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine("File not found: " + ex.Message);
// }
// finally
// {
//     if (file != null)
//     {
//         file.Close(); // Ensures file is always closed
//         Console.WriteLine("File stream closed in finally block.");
//     }
// }
