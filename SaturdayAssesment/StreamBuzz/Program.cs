using System;
using System.Collections.Generic;

public class Program
{
    public void RegisterCreator(CreatorStats record)
    {
        CreatorStats.EngagementBoard.Add(record);
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var c in records)
        {
            int count = 0;
            for (int i = 0; i < c.WeeklyLikes.Length; i++)
                if (c.WeeklyLikes[i] >= likeThreshold) count++;

            if (count > 0)
                result.Add(c.CreatorName, count);
        }
        return result;
    }

    public double CalculateAverageLikes()
    {
        double sum = 0;
        int count = 0;

        foreach (var c in CreatorStats.EngagementBoard)
            for (int i = 0; i < c.WeeklyLikes.Length; i++)
            {
                sum += c.WeeklyLikes[i];
                count++;
            }

        return count == 0 ? 0 : sum / count;
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        bool run = true;

        while (run)
        {
            Console.WriteLine("\n1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CreatorStats cs = new CreatorStats();
                Console.WriteLine("Enter Creator Name:");
                cs.CreatorName = Console.ReadLine();

                cs.WeeklyLikes = new double[4];
                Console.WriteLine("Enter weekly likes (Week 1 to 4):");
                for (int i = 0; i < 4; i++)
                    cs.WeeklyLikes[i] = Convert.ToDouble(Console.ReadLine());

                p.RegisterCreator(cs);
                Console.WriteLine("Creator registered successfully");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter like threshold:");
                double t = Convert.ToDouble(Console.ReadLine());

                var res = p.GetTopPostCounts(CreatorStats.EngagementBoard, t);
                if (res.Count == 0)
                    Console.WriteLine("No top-performing posts this week");
                else
                    foreach (var r in res)
                        Console.WriteLine(r.Key + " - " + r.Value);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Overall average weekly likes: " + p.CalculateAverageLikes());
            }
            else if (choice == 4)
            {
                Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                run = false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}

