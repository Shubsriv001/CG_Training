using System;
class Program
{
    public static void Main(string[] args)
    { 
        ShipmentDetails obj=new ShipmentDetails();

        Console.WriteLine("Enter the shipment code start with 'GC#'  and Ends with Digit");
        string code_ship=Console.ReadLine();

        Console.WriteLine("Enter the Transport Mode line Sea, Air, Land:");
        string mode_ship=Console.ReadLine();

        Console.WriteLine("Enter the Weight :");
        double weight_ship=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Storage Days:");
        int storage_ship=Convert.ToInt32(Console.ReadLine());


        obj.ShipmentCode=code_ship;
        obj.TransportMode=mode_ship;
        obj.Weight=weight_ship;
        obj.StorageDays=storage_ship;

        if(obj.ValidateShipmentCode())
        {
            Console.WriteLine("Valid Shipment Code");
            Console.WriteLine("The total shipping cost is "+obj.CalculateTotalCost());
        }
        else
        {
            Console.WriteLine("Invalid Shipment Code");
        }
    }
    
}