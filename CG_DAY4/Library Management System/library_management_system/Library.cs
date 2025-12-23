// using System;

// class Library
// {
//    private Dictionary<int, string> book = new Dictionary<int, string>();



//      public string this[int index]
//     {
//         get { return book[index]; }
//         set { book[index] = value; }
//     }

//     public string this[string name]
//     {
//         get
//         {
//             return book.FirstOrDefault(e => e.Value == name).Value;
//         }
//     }


//     public static void Main(string[] args)
//     {
//         Library library_obj=new Library();
//         library_obj[0]="Harry Potter";
//         library_obj[1]="Merchant of venice";
//         library_obj[2]="The Tempest";

//         Console.WriteLine("Books are access by using the Index: ");

//         Console.WriteLine($"Name of the 1st Book is: {library_obj[0]}");
//         Console.WriteLine($"Name of the 2nd Book is: {library_obj[1]}");
//         Console.WriteLine($"Name of the 3rd Book is: {library_obj[2]}");


//         Console.WriteLine("");

//         Console.WriteLine("Books are access by using its name: ");

//         Console.WriteLine($"Name of the 1st Book is: {library_obj["Harry Potter"]}");
//         Console.WriteLine($"Name of the 2nd Book is: {library_obj["Merchant of venice"]}");
//         Console.WriteLine($"Name of the 3rd Book is: {library_obj["The Tempest"]}");
//     }
// }