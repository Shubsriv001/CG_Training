using System;
using System.Collections.Generic;

// TASK 1
struct PriceSnapshot
{
    public string StockSymbol;
    public double StockPrice;
}

// TASK 5
static class TradeAnalytics
{
    public static int track_total_trades;

    public static void DisplayAnalytics()
    {
        Console.WriteLine($"Total Trades are: {track_total_trades}");
    }
}

// TASK 2
abstract class Trade
{
    public int Trade_ID;
    public string Stock_Symbol;
    public int Quantity;

    protected abstract double CalculateTradeValueInternal();

    public double CalculateTradeValue()
    {
        return CalculateTradeValueInternal();
    }

    public override string ToString()
    {
        return $"{Trade_ID} {Stock_Symbol} {Quantity}";
    }
}

// TASK 4
class TradeRepository<T> where T : Trade
{
    private List<int> trades = new List<int>();

    public void AddTrades()
    {
        Console.WriteLine("How many trades do you want to add?");
        int numberOfTrades = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numberOfTrades; i++)
        {

            trades.Add(i);
            TradeAnalytics.track_total_trades++;
            Console.WriteLine($"Trade {i + 1} added to repository.");
        }

        TradeAnalytics.DisplayAnalytics();
    }
}

// TASK 3
class EquityTrade : Trade
{


    protected override double CalculateTradeValueInternal()
    {
        Console.WriteLine("Please Enter the Market Price:");
        double marketPrice = Convert.ToDouble(Console.ReadLine());

        double tradeValue = marketPrice * Quantity;
        Console.WriteLine("Trade Value: " + tradeValue);
    

        return tradeValue;
    }

    static void Main(string[] args)
    {
        // TASK 1: 
        PriceSnapshot ps = new PriceSnapshot
        {
            StockPrice = 1000,
            StockSymbol = "AAPL"
        };

        Console.WriteLine("---------------Price Snapshots-------------------");
        Console.WriteLine($"Stock Price: {ps.StockPrice}");
        Console.WriteLine($"Stock Symbol: {ps.StockSymbol}");
        Console.WriteLine();

        // TASK 3: 
        EquityTrade equityTrade_obj1 = new EquityTrade();
    
            equityTrade_obj1.Quantity = 10;
            equityTrade_obj1.Trade_ID=5;
            equityTrade_obj1.Stock_Symbol="asd";
            
        EquityTrade equityTrade_obj2 = new EquityTrade();
            
            equityTrade_obj1.Quantity = 20;
            equityTrade_obj1.Trade_ID=50;
            equityTrade_obj1.Stock_Symbol="dps";
        
            equityTrade_obj1.CalculateTradeValue();
            equityTrade_obj2.CalculateTradeValue();

        // TASK 4: 
        TradeRepository<EquityTrade> tradeRepository = new TradeRepository<EquityTrade>();
        tradeRepository.AddTrades();
    }
}
