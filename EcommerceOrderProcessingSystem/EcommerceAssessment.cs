using System;

// Task1------------------------------
class Repository<T>
{
    private List<T>items=new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public List GetAll()
    {
        return items;
    }
}

// Task2----------------------------
class Order
{
    public int OrderId{get;set;}
    public string CustomerName{get;set;}
    public double Amount{get;set;}

    public override string ToString()
    {
        Console.WriteLine($"Order Id: {OrderId}, Customer Name: {CustomerName} and Amount: {Amount}");
    }
}


// Task3----------------------------------

public delegate void OrderCallback(string message);


// Task4----------------------------------
class OrderProcessor
{
    public event Action<string>OrderProcessed;


    public void ProcessOrder(
    Order order,
    Func<double,double>taxCalculator, 
    Func<double,double>discountCalculator,
    Predicate<Order>Validator,
    OrderCallback callback
    )

    {
        if (!Predicate(order))
        {
            callback("Order Validation Failed");
            return;
        }


        
    }
}