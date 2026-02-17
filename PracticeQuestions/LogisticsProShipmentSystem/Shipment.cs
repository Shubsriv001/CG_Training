using System;
class Shipment
{
    public string ShipmentCode{get;set;}
    public string TransportMode{get;set;}
    public double Weight{get;set;}
    public int StorageDays{get;set;}
}

class ShipmentDetails:Shipment
{
    
        
    public bool ValidateShipmentCode()
    {

        string code="";
        for(int i = 0; i < 3; i++)
        {
            code+=ShipmentCode[i];
        }
       
       
       char c=ShipmentCode[3];
        if(ShipmentCode.Length==7 && code=="GC#" && char.IsDigit(c))
        {
            return true;
        }
        return false;

    }

        public double CalculateTotalCost()
    {
        if (TransportMode == "Sea")
        {
            
        double TotalCost=(Weight*15.00)+Math.Sqrt(StorageDays);
        double round=Math.Round(TotalCost,2);
        return round;
        }

        else if (TransportMode == "Air")
        {
        
        double TotalCost=(Weight*50.00)+Math.Sqrt(StorageDays);
        double round=Math.Round(TotalCost,2);
        return round;
        }
        else if (TransportMode == "Land")
        {
            
        double TotalCost=(Weight*25.00)+Math.Sqrt(StorageDays);
        double round=Math.Round(TotalCost,2);
        return round;
        }
        return 0.0;

    }


    }