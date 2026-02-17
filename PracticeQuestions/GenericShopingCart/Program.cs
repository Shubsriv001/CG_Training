using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public override bool Equals(object obj)
    {
        return obj is Product p && p.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

public class Item : Product
{
}

public class ShoppingCart<T> where T : Product
{
    private Dictionary<T, int> _cartItems = new();

    public void AddToCart(T product, int quantity)
    {
        if (_cartItems.ContainsKey(product))
            _cartItems[product] += quantity;
        else
            _cartItems[product] = quantity;
    }

    public double CalculateTotal(Func<T, double, double> discountCalculator = null)
    {
        double total = 0;

        foreach (var item in _cartItems)
        {
            double price = item.Key.Price * item.Value;

            if (discountCalculator != null)
                price = discountCalculator(item.Key, price);

            total += price;
        }

        return total;
    }

    public List<T> GetTopExpensiveItems(int n)
    {
        return _cartItems.Keys
                         .OrderByDescending(p => p.Price)
                         .Take(n)
                           .ToList();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ShoppingCart<Item> cart = new ShoppingCart<Item>();

        Console.Write("Enter number of products: ");
        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Item product = new Item();

            Console.Write("Enter Product Id: ");
            product.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            product.Name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            product.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            cart.AddToCart(product, qty);
        }

        double total = cart.CalculateTotal();
        Console.WriteLine(total);

        double totalWithDiscount = cart.CalculateTotal((product, price) => price * 0.9);
        Console.WriteLine(totalWithDiscount);

        Console.Write("Enter number of top expensive items: ");
        int n = Convert.ToInt32(Console.ReadLine());

        var topItems = cart.GetTopExpensiveItems(n);

        foreach (var item in topItems)
        {
            Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
        }
    }
}
