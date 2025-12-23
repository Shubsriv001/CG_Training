using System;
class Overload_constructor
{

     public string? Name;
     public int Price;

    //   public Overload_constructor() {  }

    public Overload_constructor(string name, int price)
    {
        Name = name;
        Price = price;
    }
    public static void Main(string[] args)
    {
        Overload_constructor overload_Constructor_obj=new Overload_constructor{Name = "Laptop",Price = 50000};
    }

}