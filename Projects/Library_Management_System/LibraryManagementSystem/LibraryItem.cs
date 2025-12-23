using System;

namespace LibraryManagementSystem
{
    abstract class LibraryItem
    {
        public abstract void display_item_details();
        public abstract void calculate_late_fee();

        protected string Title;
        protected string Author;
        protected int ItemID;
    }

    class Book : LibraryItem

    {
        public override void calculate_late_fee()
        {
            Console.Write("Enter Book Title: ");
            Title = Console.ReadLine();

            Console.Write("Enter Author: ");
            Author = Console.ReadLine();

            Console.Write("Enter Item ID: ");
            ItemID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number of Books: ");
            int numberOfBooks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Late Days: ");
            int lateDays = Convert.ToInt32(Console.ReadLine());

            double lateFee = numberOfBooks * 1 * lateDays;
            Console.WriteLine($"Late Fee: {lateFee}");
        }

        public override void display_item_details()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Item Type: Book");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemID}");
        }
    }

    class Magazine : LibraryItem
    {
        public override void calculate_late_fee()
        {
            Console.Write("Enter Magazine Title: ");
            Title = Console.ReadLine();

            Console.Write("Enter Author: ");
            Author = Console.ReadLine();

            Console.Write("Enter Item ID: ");
            ItemID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number of Magazines: ");
            int numberOfBooks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Late Days: ");
            int lateDays = Convert.ToInt32(Console.ReadLine());

            double lateFee = numberOfBooks * 0.5 * lateDays;
            Console.WriteLine($"Late Fee: {lateFee}");
        }

        public override void display_item_details()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Item Type: Magazine");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemID}");
        }
    }
}
