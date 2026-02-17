using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public bool IsAvailable { get; set; } = true;
}

public class Catalog<T> where T : Book
{
    private List<T> _items = new();
    private HashSet<string> _isbnSet = new();
    private SortedDictionary<string, List<T>> _genreIndex = new();

    public bool AddItem(T item)
    {
        if (_isbnSet.Contains(item.ISBN))
            return false;

        _isbnSet.Add(item.ISBN);
        _items.Add(item);

        if (!_genreIndex.ContainsKey(item.Genre))
            _genreIndex[item.Genre] = new List<T>();

        _genreIndex[item.Genre].Add(item);

        return true;
    }

    public List<T> this[string genre]
    {
        get
        {
            return _genreIndex.ContainsKey(genre)
                ? _genreIndex[genre]
                : new List<T>();
        }
    }

    public IEnumerable<T> FindBooks(Func<T, bool> predicate)
    {
        return _items.Where(predicate);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Catalog<Book> catalog = new Catalog<Book>();

        Console.Write("Enter number of books: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Book book = new Book();

            Console.Write("\nEnter ISBN: ");
            book.ISBN = Console.ReadLine();

            Console.Write("Enter Title: ");
            book.Title = Console.ReadLine();

            Console.Write("Enter Author: ");
            book.Author = Console.ReadLine();

            Console.Write("Enter Genre: ");
            book.Genre = Console.ReadLine();

            bool added = catalog.AddItem(book);

            if (added)
                Console.WriteLine("Book added successfully.");
            else
                Console.WriteLine("Duplicate ISBN. Book not added.");
        }

        Console.Write("\nEnter genre to display books: ");
        string genreSearch = Console.ReadLine();

        var genreBooks = catalog[genreSearch];

        Console.WriteLine("\nBooks in this genre:");
        foreach (var book in genreBooks)
        {
            Console.WriteLine($"{book.ISBN} {book.Title} {book.Author}");
        }

        Console.Write("\nEnter author name to search: ");
        string authorSearch = Console.ReadLine();

        var authorBooks = catalog.FindBooks(b => b.Author == authorSearch);

        Console.WriteLine("\nBooks by this author:");
        foreach (var book in authorBooks)
        {
            Console.WriteLine($"{book.ISBN} {book.Title} {book.Genre}");
        }
    }
}
