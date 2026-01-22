using System;
using System.Diagnostics;
Trace.WriteLine("Application Execution Started");

class Chocolate
{
    public string Flavour { get; set; }
    public int Quantity { get; set; }
    public int PricePerUnit { get; set; }
    public double TotalPrice { get; set; }
    public double DiscountPrice { get; set; }
    public double discount = 0;

    public bool ValidateChocolateFlavour()
    {
        if (Flavour == "Dark" || Flavour == "Milk" || Flavour == "White")
            return true;
        return false;
    }

    public Chocolate CalculateDiscountedPrice(Chocolate chocolate)
    {
        chocolate.TotalPrice = chocolate.Quantity * chocolate.PricePerUnit;

        

        if (chocolate.Flavour == "Dark")
            discount = 18;
        else if (chocolate.Flavour == "Milk")
            discount = 12;
        else if (chocolate.Flavour == "White")
            discount = 6;

        chocolate.DiscountPrice = chocolate.TotalPrice - (chocolate.TotalPrice * discount / 100);

        return chocolate;
    }

    static void Main(string[] args)
    {
        Chocolate chocolate = new Chocolate();
        Console.WriteLine();

        Console.WriteLine("Enter the Floavour of your Chocolate From: Dark, Milk, White");
        Console.WriteLine("------------------------------------------------------------");

        Console.WriteLine("Enter the flavour");
        chocolate.Flavour = Console.ReadLine();

        Console.WriteLine("Enter the quantity");
        chocolate.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the price per unit");
        chocolate.PricePerUnit = Convert.ToInt32(Console.ReadLine());

        if (!chocolate.ValidateChocolateFlavour())
        {
            Console.WriteLine("Invalid flavour");
        }
        else
        {
                chocolate.CalculateDiscountedPrice(chocolate);

            Console.WriteLine("Flavour : " + chocolate.Flavour);
            Console.WriteLine("Quantity : " + chocolate.Quantity);
            Console.WriteLine("Price Per Unit : " + chocolate.PricePerUnit);
            Console.WriteLine("Total Price : " + chocolate.TotalPrice);
            Console.WriteLine("You Are Getting Discount Of : " +chocolate.discount+"%");
            Console.WriteLine("Discounted Price : " + chocolate.DiscountPrice);
        }
    }
}
