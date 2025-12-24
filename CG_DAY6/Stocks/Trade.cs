// // using System;

// // struct StockPrice
// // {
// //     public string stock_Symbol;
// //     public double price;
// // };

// // class Trade
// // {
// //     public int trade_Id;
// //     public string stock_Symbol;
// //     public int Quantity;

// //     public static void Main(string[] args)
// //     {
// //         StockPrice Original_price = new StockPrice
// //         {
// //             stock_Symbol = "AAPL",
// //             price = 150
// //         };

// //         StockPrice copiedPrice = Original_price;
// //         copiedPrice.price = 155.00;

// //         Trade trade1 = new Trade
// //         {
// //             trade_Id = 1,
// //             stock_Symbol = "TCS",
// //             Quantity = 100
// //         };


// //         //It will change the object value from the reference address.

// //         Trade trade2 = trade1;
// //         trade2.Quantity = 200;

// //         Console.WriteLine($"Original price of the stock is : {Original_price.price}");
// //         Console.WriteLine($"Copied price of the stock is : {copiedPrice.price}");
// //         Console.WriteLine($"Trade 1 Quantity: {trade1.Quantity}");
// //         Console.WriteLine($"Trade 2 Quantity: {trade2.Quantity}");
       
// // }
// // }


// // -------------------------------------------------------------------------
// // class Portfolio
// // {
// //     public string Name;

// //     public override bool Equals(object obj)
// //     {
// //         Portfolio p = obj as Portfolio;
// //         return p != null && p.Name == Name;
// //     }
// // }

// // class Program
// // {
// //     static void Main()
// //     {
// //         Portfolio p1 = new Portfolio { Name = "Growth" };
// //         Portfolio p2 = new Portfolio { Name = "Growth" };

// //         Console.WriteLine(p1.Equals(p2)); // it checks value.
// //         Console.WriteLine(p1==p2); //here it checks address location.

// //     }
// // }

// // ----------------------------------------------------------------------

// using System;

// class Portfolio
// {
//     public string Name;

//     public override bool Equals(object obj)
//     {
//         Portfolio p = obj as Portfolio;
//         return p != null && p.Name == Name;
//     }

//     public override int GetHashCode()
//     {
//         return Name.GetHashCode();
//     }

//     public static void Main(string[] args)
//     {
//         Portfolio portfolio_obj1 = new Portfolio
//          { 
//             Name = "Growth"
//              };

//         Portfolio portfolio_obj2 = new Portfolio
//          { 
//             Name = "Growth"
//              };

//         Console.WriteLine();
//         Console.WriteLine($"Code1: {portfolio_obj2.GetHashCode()} code2: {portfolio_obj1.GetHashCode()}");
//         Console.WriteLine(portfolio_obj2.GetHashCode().Equals(portfolio_obj1.GetHashCode()));
//         Console.WriteLine(portfolio_obj1.GetType()); // It will Return the Object Type..(Portfolio) 
//         Console.WriteLine();
//     }
// }
