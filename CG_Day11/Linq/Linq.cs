// // present in the 'namespace System.Linq'
// //  the linq won't work until we started accesing the value.. aslo known as deffered Execution // 
//  class Linq 
//  {  
    

//     // This is the example Sorting the Salary in the Ascending order....
// //     class Emplyoee
// // {
// //     public string Name{get;set;}
// //     public int Salary{get;set;}
// // }



// // List<Emplyoee> emplyoees=new List<Emplyoee>
// // {
// //     new Emplyoee{Name ="Amit",Salary=50000},
// //     new Emplyoee{Name ="Ravi",Salary=60000},
// //     new Emplyoee{Name ="Neha",Salary=70000},
// // };

    
//     public static void Main(string[] args) 

//  {  //int []number={1,2,3,4,5,6,7,8,9}; 


// //  var evenNumber=number.Where(n=> n%2==0);

// //  var numbers_a=number.Where(n => n > 3) . Select(n => n * 2) ; 

// //  var ascending=number.OrderBy(n=>n);
// //  var descending=number.OrderByDescending(n=>n);


// //  Console.WriteLine("type of: "+numbers_a.GetType()); 
// //  Console.WriteLine("Even Numbers are:");


// // // ---------------------------------------------------
// // Console.WriteLine("Printing the number in the descending order: ");
// //   foreach(var n in descending) 
// //   {  Console.WriteLine(n); 
// //  } 

// //  // ---------------------------------------------------

// // Console.WriteLine("Printing the number in the Ascending order: ");
// //   foreach(var n in ascending) 
// //   {  Console.WriteLine(n); 
// //  } 



// // var SortedBySalary=Emplyoee.OrderBy(e=>e.Salary);

// // foreach(var  S in SortedBySalary)
// //         {
// //             System.Console.WriteLine(s);
// //         }







//  }}

//  //  class Student 
//  // { string name;
//  //  int marks; 
//  // string grade; 
//  // public static void Main(string[] args) 
//  // { Student student_obj0=new Student(); 
//  // Student student_obj1=new Student();
//  //  Student student_obj2=new Student();
//  //  Student student_obj3=new Student();
//  //  Student student_obj4=new Student();
//  //  var result = Student.Select(s => new { s.name, Grade=s.marks>60? "Pass":"Fail" });
//  // } }





// using System;

// class ResourceHandler : IDisposable
// {
//     public ResourceHandler()
//     {
//         Console.WriteLine("Resource acquired");
//     }

//     public void Dispose()
//     {
//         Console.WriteLine("Resource released");
//     }

//     static void Main(string[] args)
//     {
//         using (ResourceHandler resourceHandler = new ResourceHandler())
//         {
//             Console.WriteLine("Resource called...");
//         }

//         Console.WriteLine("End of Program...");

//     }
// }