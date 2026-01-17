using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        RealEstate obj1=new RealEstate
        {
              ID=101, Title="Great vila",Description="This vila Near to the seashore have Morning Sunshine Directly inside the room",Price=50000000,Location="ABC"
        };
        RealEstate obj2=new RealEstate
        {
              ID=102, Title="Dream Vila",Description="All Luxury items are made using gold",Price=700000000,Location="ABC"
        };

           
        RealEstateApp realEstateApp_obj=new RealEstateApp();
        realEstateApp_obj.AddListing(obj1);
        realEstateApp_obj.AddListing(obj2);

        Console.WriteLine();

        Console.WriteLine("Below is the Complete List of Properties Present in the list are: ");
        Console.WriteLine();
        
        realEstateApp_obj.GetListings();
        Console.WriteLine();

        realEstateApp_obj.GetListingsByLocation();
        Console.WriteLine();

        realEstateApp_obj.GetListingsByPriceRange();
        Console.WriteLine();

        realEstateApp_obj.RemoveListing();
        Console.WriteLine();

        realEstateApp_obj.UpdateListing();
        Console.WriteLine();





    }
}