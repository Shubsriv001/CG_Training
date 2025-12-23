// using System;
// using System.Security.Claims;

// class Interface
// {
//     interface IReservable
//     {
//         void reservation();
//     }

//     interface INotifiable
//     {
//         void notification();
//     }

//     class Book : IReservable, INotifiable
//     {
//     public void reservation()
//         {
//             Console.WriteLine("Reservation success");
//         }

//         public void notification()
//         {
//                 Console.WriteLine("Please Enter the Message:");
//                 string message=Console.ReadLine();
//             Console.WriteLine($"Notification message sent: {message}");
//                     }
//     }
//     public static void Main(string[] args)
//     {
//         Book book_obj=new Book();
//         Console.WriteLine();
//         Console.WriteLine("-----------------------------------");
//         book_obj.reservation();
//         book_obj.notification();
//     }
// }