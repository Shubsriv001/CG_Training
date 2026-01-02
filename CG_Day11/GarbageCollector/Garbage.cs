// using System;
// using System.Xml.Serialization;
// class Garbage
// {
//     public static void Main(string[] args)
//     {
        
//     System.Console.WriteLine("Crearting Objects....");
//     for(int i = 0; i < 5; i++)
//         {
//             MyClass myClass_obj=new MyClass();
//         }

//         System.Console.WriteLine("Forcing Grbage Collection Complete...");
//         GC.Collect();
//         GC.WaitForPendingFinalizers();
//         System.Console.WriteLine("Garbage collection Complete....");
//     }
// }



// class MyClass
// {
//     ~MyClass()
//     {
//         System.Console.WriteLine("Finalizer Called, Object Collected..");
//     }
// }











