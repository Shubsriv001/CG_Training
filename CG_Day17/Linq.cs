using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;

class Student
{
    public string? Name { get; set; }
    public string? Grade { get; set; }
    public int Marks { get; set; }
}

class Program
{
    public static void Main(string[] args)
    {
        // var students = new List<Student>
        // {
        //     new Student { Name = "Ayush", Marks = 10 },
        //     new Student { Name = "Aditya", Marks = 80 }
        // };

    //     var result = students.Select(s => new
    //     {
    //         s.Name,
    //         Grade = s.Marks > 60 ? "Pass" : "Fail"
    //     }).ToList();

    //     Console.WriteLine( "Type of: "+result.GetType());

    //     foreach (var r in result)
    //         Console.WriteLine($"{r.Name} - {r.Grade}");
   
// ------------------------------OrderBy------//-----------------------//--------------------//---------

//    var sortedByMarks = students.OrderBy(s => s.Marks);

//    var sortedByMarks = students.OrderByDescending(s => s.Marks);

//         foreach (var s in sortedByMarks)
//         {
//             Console.WriteLine($"{s.Name} - {s.Marks}");
//         }


// ------------------------//------------------------/----ThenBy--------------------//-----------------


//  var sortedByMarks = students.Order(s => s.Marks).ThenBy(s.Name);

//         foreach (var s in sortedByMarks)
//         {
//             Console.WriteLine($"{s.Name} - {s.Marks}");
//         }





// ===========================//=======First, Last, Methodes in Linq=============//=======================//===================



List<int> numbers=[1,4,2,5,7,8,4,5,2,3,8,12,12,45,85,447,78];

// int fisrt=numbers.First();  // this will return the first occuring in the list
// int last=numbers.Last();   // this will return the last ocurring in the list
// Console.WriteLine("First Number in the List: "+fisrt);
// Console.WriteLine("Last number present in the list: "+last);
// int result=numbers.Last(n=>n<25);
// Console.WriteLine(result);

// Use of Single:- this will return the single value mostly used when there is only single element in the array or the list.....

int value=numbers.Single();
Console.WriteLine(value);


    }
}
