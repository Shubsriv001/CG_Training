// using System;


// class Calculate
// {



// // Generic collections

// List<T> numbers = new List<T>();


// ------------------------------------------------------------
// GENERIC CLASS....

// class Box<T>
// {
//     public T Value;
// }

// Box<int> b = new Box<int>();
// b.Value = 100;

// -----------------------Example----------------------------------------

//Only reference types are alllowed and T is the placeholder
// using System;

// class Repository<T>
// {
//     public T data;
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Repository<int> obj = new Repository<int>();
//         obj.data = 100;

//         Console.WriteLine(obj.data);
//     }
// }

// -----------------------------------------------------------------
// Generic Methode.....

// static void Show<T>(T data)
// {
//     Console.WriteLine(data);
// }

// Show<string>("Hello");
// Show<int>(10);

// --------------------------Examples-------------------------------------


//     public T calculator<T>(T data)
//     {
//         Console.WriteLine(data);
//         return data; 
//     }

   
//         Calculate obj = new Calculate();
//         int result = obj.calculator<int>(10);

//         Console.WriteLine( result);
//     }
// }



// ---------------------------------------------------------------
// GENERIC COLLECTION....

// List<int> numbers = new List<int> { 1, 2, 3 };

// Dictionary<int, string> students = new Dictionary<int, string>();
// students.Add(1, "Amit");


// ------------------------------------------------------------------
// Generic Class with Constraint.....

// class Printer<T> where T : class
// {
//     public void Print(T data)
//     {
//         Console.WriteLine(data);
//     }
// }


// --------------------------------------------------------------------
//







//  public static void Main(string[] args)
//     {
        






//     }
// }




