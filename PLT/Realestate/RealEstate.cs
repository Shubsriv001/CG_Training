using System;
using System.Collections.Generic;
class RealEstate
{
   public int ID{get;set;}
   public string Title{get;set;}
   public string Description{get;set;}
   public int Price{get;set;}
   public string Location{get;set;}
}

class RealEstateApp
{
    List<RealEstate>listing= new List<RealEstate>();

    public void AddListing(RealEstate realEstate)
    {
        listing.Add(realEstate);
    }
    public void RemoveListing()
    {
        Console.WriteLine("Enter the Property ID to Remove the Listing:");
        int id=Convert.ToInt32(Console.ReadLine());
        foreach(var li in listing)
        {
            if(li.ID==id)
            {
                listing.Remove(li);
                Console.WriteLine("Listing Removed Successfully");
                break;
            }
        }  

        Console.WriteLine("Updated Lists: ");
        GetListings();      
    }

    public void UpdateListing()
    {
        Console.WriteLine("Enter the Property ID to Update the Listing:");
        int id=Convert.ToInt32(Console.ReadLine());
        foreach(var li in listing)
        {
            if(li.ID==id)
            {
                Console.WriteLine("Enter the New Title:");
                li.Title=Console.ReadLine();
                Console.WriteLine("Enter the New Description:");
                li.Description=Console.ReadLine();
                Console.WriteLine("Enter the New Price:");
                li.Price=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the New Location:");
                li.Location=Console.ReadLine();
                Console.WriteLine("Listing Updated Successfully");
                break;
            }
        }
        Console.WriteLine("Updated Lists: ");
        GetListings(); 

    }

    public void GetListings()
    {
         foreach(var li in listing)
        {
            Console.WriteLine($"Property ID: {li.ID}, Name: {li.Title}, Description: {li.Description}, Price: {li.Price}, Location: {li.Location}");
        }
    }

    public void GetListingsByLocation()
    {
        Console.WriteLine("Enter the location You want to search:");
        string location=Console.ReadLine();
        foreach(var li in listing)
        {
            if (li.Location == location)
            {
                Console.WriteLine($"Property Present at {location} are {li.Title}");
            }
        }
    }
    public void GetListingsByPriceRange()
    {
        Console.WriteLine("Enter the Min Price");
        int minPrice=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Max Price");
        int maxPrice=Convert.ToInt32(Console.ReadLine());

        foreach(var li in listing)
        {
            if(li.Price >= minPrice && li.Price <= maxPrice)
            {
                Console.WriteLine($"Name: {li.Title} Price: {li.Price}");
            }           
        }
    }
}