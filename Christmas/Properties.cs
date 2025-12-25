using System;
namespace Christmas
{
    
class Circle

{
    //By default the member field is Private so we can not access it out side of the class means in any other class or file.
    //To access outside we need to make a member methode for accessing or updating.
     double Radius=20.0;


        // ----------------------To Overcome this Method Creation We use Properties----------------------\\

    //  public double getRadius() // For accessing the Radius value to another class ( Works as ReadOnly).
    // {
    //     return Radius;
    // }

    //  //Both the method Combined works as set and get only
    //  public void setRadius(double value) // For Setting the Radius value from another class ( Works as setOnly).
    // {
    //      Radius=value;
    // }



    // Syntax For Properties

    // [<Modifiers>] <Type> <Name>]
    //{
    //     [get{<Stmt>}] //Get Accessor
    //     [set{<Stmt>}] //Set Accessor
    // }

    //The Above Two Method now be written in sorter way

    public double RadiusProperty
        {

            get
            {
                return Radius;
            }

            set
            {
                Radius=value;

            }
        }

         // Below is the auto-Implemented Property
         // public double RadiusProperty{get;set;}




}

}