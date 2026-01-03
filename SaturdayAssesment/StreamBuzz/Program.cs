using System;
class Program
{

  public void RegisterCreator()
    {        
        Console.WriteLine();
        Console.WriteLine("Enter Creator Name:");
        string c_name=Console.ReadLine();
        if (c_name == "")
        {
            System.Console.WriteLine("Please Enter valid Name.");
            return;
        }
        else
        {
            creator_name=c_name;
        }
        
        Console.WriteLine("Enter weekly likes (Week 1 to 4):");
            
            WeeklyLikes=new double[4];

            for(int i = 0; i < 4; i++)
        {
        Console.WriteLine($"Enter weekly likes for week {i+1}:");
        int week_value=Convert.ToInt32(Console.ReadLine());
        WeeklyLikes[i]=week_value;
        }

        Console.WriteLine("Creator registered successfully");        
    }
    public void GetTopPostCounts()
    {
        Console.WriteLine();
        Console.WriteLine("Enter like threshold:");
        int th_likes=Convert.ToInt32(Console.ReadLine());
        if(th_likes < 0)
        {
            System.Console.WriteLine("Please Enter the valid Threshold number.");
        }
        else
        {
            threshold_like=th_likes;
        }
    }
        public double CalculateAverageLikes()
    {
    }   


    // =============//===================//===================//=======================//============//

    public static void Main(string[] args)
    {
        bool run=true;
        while (run)
        {
         Console.WriteLine();   
         Console.WriteLine("1) Register Creator\n2) Show Top Posts\n3) Calculate Average Likes\n4) Exit");
         Console.WriteLine();   
         Console.WriteLine("Enter your choice:");
            int choice=Convert.ToInt32(Console.ReadLine());

            if (choice == 4)
            {
                System.Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                return;
            }
            else
            {
                
            Console.WriteLine();   
            switch (choice)
            {
                case 1:
                    Console.WriteLine("choosed option one ");
                break;

                case 2:
                break;

                case 3:
                break;

                case 4:
                    System.Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                break;

               default:
               System.Console.WriteLine("Invalid Input");
               break;
            }}}}}