using System;

class Student
{

   private string name;
    private int age;
    private double marks;
    private string password;
//Auto implemented properties are:

    public int Student_ID{get;set;}

    public string Password
    {
        set
        {
            if (value.Length >= 6)
            {
                password = value;
            }
            else
            {
                Console.WriteLine("Please Enter Six Length Password");
            }
        }
    }


    public string name_property
    {
        get{return name;}
        set{
            if (!string.IsNullOrEmpty(value))
            {
                name=value;
            }
        }
    }
    public int age_property
    {
        get{return age;}
        set{
            if (age >0)
            {
                age=value;
            }
        }
    }

    public double marks_property
    {
        get{return marks;}
        set{
            if (marks >0 && marks<=100)
            {
                marks=value;
            }
        }
    }


    public string result
    {
        get
        {
            return marks>=40? "Pass":"Fail";
        }
    }






    public static void Main(string[] args)
    {

     Student student_obj=new Student();
     student_obj.name="Shubahnshu";
     student_obj.age=21;
     student_obj.marks=20; 
     student_obj.Password="1k235";  
     Console.WriteLine($"Student data are : {student_obj.name}, age: {student_obj.age}, marks: {student_obj.marks}, password is {student_obj.password}");
    }
}