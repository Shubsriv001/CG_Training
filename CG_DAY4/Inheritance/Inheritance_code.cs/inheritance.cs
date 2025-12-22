// using System;

// class Inheritance
// {

//     class Person
//     {
//         string name="";
//         public Person(string Name)
//         {
//             this.name=Name;
//         }
//     }


//     class Student:Person
//     {
//         int roll_number;

//         public Student(int roll_number,string name):base(Name)
//         {
//             this.roll_number=roll_number;

//         }

//     }

//     public static void Main(string[]args)
//     {
//         Person person_obj=new Person("shubh");
//         Student student_obj=new Student(1,"shubh");



//     }
// }


// ---------------------------------------Interfaces---------------------------------------------



using System;


interface start
{
    
    void starting();
}
interface stop
{
    void stoping();
}

class Run:start,stop
{
    public void starting()
    {
        Console.WriteLine("Engine started");
    }


    public void stoping()
    {
        Console.WriteLine("Engine stoped");
        
    }


    public static void Main(string[]args)
    {
        Run run_obj=new Run();
        run_obj.starting();
        run_obj.stoping();
    }
}
