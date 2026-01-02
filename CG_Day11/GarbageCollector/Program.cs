using System;
using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
class Program{



class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Deconstruct(out int id, out string name)
    {
        id = Id;
        name = Name;
    }
}




public static void Main(string[] args)
    {
        // var Student = (ld: 101, Name: "Amit");

        // //This is the example of tuple.....
        // (int,string) student1=(101,"Shubhanshu");

        // //This is the anonymous type and this is only read not for updation....
        // var a=new {x=10,y=20};
        

        // Console.WriteLine(Student.GetType());
        // Console.WriteLine(student1.GetType());
        // Console.WriteLine(a.GetType()); // to get the type of variable
        
// ----------------------------------------------------------------------------
    // This is the example of tuple that returns multiple value this can be use at the place of 'out'

    // (int sum,int sub, int avg) Calculate(int a, int b)
    //     {
    //         return(a+b,a-b,(a+b)/2);
    //     }
    
    //     var Sums=Calculate(10,20);
    //         Console.WriteLine($"Sum of the number is {Sums.sum} and the average of the number is {Sums.avg} and the diff is {Sums.sub}");

    //         Console.WriteLine(Sums.GetType());


// -----------------------------------------------------------------------------

//Returning Multiple Values from method using tuple....

    //  static(bool IsValid, string Message) ValidateUser(string username)
    //     {
    //         if (string.IsNullOrEmpty(username))
    //         {
    //             return (false, "Username is Required");
    //         }
    //         return (true, "Valid user");
    //     }

    //     var response=ValidateUser("Admin");
    //     Console.WriteLine(response.IsValid);
    //     Console.WriteLine(response.Message);


// ------------------------------------------------------------------------------

//Below is the example of Deconstructing a tuple

// var person=(Id:1,name:"Shubhanshu");
// // System.Console.WriteLine(person.Id);

// // var (id, name)=person;
// // here we  are using _ to discart the or to skip the value, NOTE  
// var(_, name)=person;

// Console.WriteLine(person.name);
// // Console.WriteLine(id);
// // Console.WriteLine(person.GetType());
// // Console.WriteLine(id.GetType());
// Console.WriteLine(name.GetType());



// ------------------------------------------------------------------------------

// var s = new Student { Id = 1, Name = "Amit" };
// Console.WriteLine(s.GetType());
// var (sid, sname) = s;
// Console.WriteLine(sid);
// Console.WriteLine(sname);

// ------------------------------------------------------------------------------





    }
}
