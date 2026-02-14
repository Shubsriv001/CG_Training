using System;

namespace BookStoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // 1. Read initial input
            // Format: BookID Title Price Stock
            Console.WriteLine("Enter Book Data Seperated by spaces in BookId Title Price Stock");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');


            Book book = new Book();
            book.Id = parts[0];
            book.Title = parts[1];
            book.Price = int.Parse(parts[2]);
            book.Stock = int.Parse(parts[3]);
        

            BookUtility utility = new BookUtility(book);

            while (true)
            {
                // TODO:
                // Display menu:
                // 1 -> Display book details
                // 2 -> Update book price
                // 3 -> Update book stock
                // 4 -> Exit

                Console.WriteLine("1. Display book details\n2. Update book price\n3. Update book stock\n4. Exit");

                int choice = 0; // TODO: Read user choice
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.GetBookDetails();
                        break;

                    case 2:
                        // TODO:
                        // Read new price
                        // Call UpdateBookPrice()
                        Console.WriteLine("Enter the new Price");
                        int new_price=Convert.ToInt32(Console.ReadLine());
                        utility.UpdateBookPrice(new_price);
                        break;

                    case 3:
                        // TODO:
                        // Read new stock
                        // Call UpdateBookStock()
                        Console.WriteLine("Enter the new Stock");
                        int new_stock=Convert.ToInt32(Console.ReadLine());
                        utility.UpdateBookStock(new_stock);
                        break;

                    case 4:
                        Console.WriteLine("Thank You");
                        return;

                    default:
                        // TODO: Handle invalid choice
                        Console.WriteLine("Invalid Selection.");
                        break;
                }
            }
        }
    }
}
