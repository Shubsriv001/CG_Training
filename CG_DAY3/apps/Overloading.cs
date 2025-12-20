// using System;

// class Overloading
// {
//     public static void add(int a,int b)
//     {
//         Console.WriteLine(a+b);
//     }
//     // public void add(int a,int b, int c)
//     // {
//     //     Console.WriteLine(a+b+c);
//     // }

//     public void add(double a,double b)
//     {
//         Console.WriteLine(a+b);
//     }

//     public static void Main(string[] args)
//     {
        
//         Overloading overloading_obj=new Overloading();
        
//         // Below we are calling the static methode using class name
//         Overloading.add(1,2);

//         // if we are not specify the accesswith public then we need to call its object
//         // overloading_obj.add(1002,25);



//         // Console.WriteLine("Displaying Three Integer data function");
//         // overloading_obj.add(15,25,50);
//         // Console.WriteLine("Displaying two double data function");
        
//         // // int the below code inter value get to 25.0 
//         // overloading_obj.add(100.2,25);

//         overloading_obj.add(100.2,2.5);

//     }
// }