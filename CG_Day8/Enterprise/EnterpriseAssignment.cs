using System;
using System.Collections;
using System.Collections.Generic;

class Enterprise
{
    static void Main()
    {

       
        Console.WriteLine("TASK 1: DYNAMIC PRODUCT PRICE ANALYSIS");

        Console.Write("Enter number of products: ");
        int productCount = int.Parse(Console.ReadLine());

        int[] prices = new int[productCount];
        int sum = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            while (true)
            {
                Console.Write($"Enter positive price for product {i+1}: ");
                int val = int.Parse(Console.ReadLine());
                if (val > 0)
                {
                    prices[i] = val;
                    sum += val;
                    break;
                }
                Console.WriteLine("Invalid price. Try again.");
            }
        }

        double averagePrice = (double)sum / prices.Length;

        Array.Sort(prices);

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < averagePrice)
                prices[i] = 0;
        }

        int oldLength = prices.Length;
        Array.Resize(ref prices, oldLength + 5);

        for (int i = oldLength; i < prices.Length; i++)
            prices[i] = (int)averagePrice;

        Console.WriteLine("Final Product Prices:");
        for (int i = 0; i < prices.Length; i++)
            Console.WriteLine($"Index {i} : {prices[i]}");

// ========================================================================================================================


        Console.WriteLine("\nTASK 2: BRANCH SALES ANALYSIS");

        Console.Write("Enter number of branches: ");
        int branches = int.Parse(Console.ReadLine());

        Console.Write("Enter number of months: ");
        int months = int.Parse(Console.ReadLine());

        int[,] sales = new int[branches, months];
        int highestSale = 0;

        for (int i = 0; i < branches; i++)
        {
            for (int j = 0; j < months; j++)
            {
                Console.Write($"Enter sales for Branch {i}, Month {j}: ");
                sales[i, j] = int.Parse(Console.ReadLine());
                if (sales[i, j] > highestSale)
                    highestSale = sales[i, j];
            }
        }

        for (int i = 0; i < branches; i++)
        {
            int total = 0;
            for (int j = 0; j < months; j++)
                total += sales[i, j];

            Console.WriteLine($"Total sales of Branch {i}: {total}");
        }

        Console.WriteLine($"Highest Monthly Sale: {highestSale}");

// ========================================================================================================================


        Console.WriteLine("\nTASK 5: FINANCIAL TRANSACTION FILTERING");

        Console.Write("Enter number of transactions: ");
        int tCount = int.Parse(Console.ReadLine());

        Dictionary<int, double> transactions = new Dictionary<int, double>();

        for (int i = 0; i < tCount; i++)
        {
            Console.Write("Enter Transaction ID: ");
            int id = int.Parse(Console.ReadLine());

            if (transactions.ContainsKey(id))
            {
                Console.WriteLine("Duplicate ID not allowed.");
                i--;
                continue;
            }

            Console.Write("Enter Amount: ");
            double amt = double.Parse(Console.ReadLine());

            transactions.Add(id, amt);
        }

        SortedList<int, double> highValueTxns = new SortedList<int, double>();

        foreach (KeyValuePair<int, double> item in transactions)
            if (item.Value >= averagePrice)
                highValueTxns.Add(item.Key, item.Value);

        Console.WriteLine("High Value Transactions:");
        foreach (KeyValuePair<int, double> item in highValueTxns)
            Console.WriteLine($"ID: {item.Key}, Amount: {item.Value}");

// ========================================================================================================================

        Console.WriteLine("\nTASK 6: PROCESS FLOW MANAGEMENT");

        Console.Write("Enter number of operations: ");
        int operations = int.Parse(Console.ReadLine());

        Queue<string> processQueue = new Queue<string>();
        Stack<string> undoStack = new Stack<string>();

        for (int i = 0; i < operations; i++)
        {
            Console.Write($"Enter operation {i}: ");
            string op = Console.ReadLine();
            processQueue.Enqueue(op);
            undoStack.Push(op);
        }

        Console.WriteLine("Processed Operations:");
        while (processQueue.Count > 0)
            Console.WriteLine(processQueue.Dequeue());

        Console.WriteLine("Undo Operations:");
        for (int i = 0; i < 2 && undoStack.Count > 0; i++)
            Console.WriteLine(undoStack.Pop());
    }
}
