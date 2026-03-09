using System;
using System.Collections;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float? Height { get; set; }
    public float AttendancePercentage { get; set; }
}

class Program
{
    public static void Main()
    {
        ArrayList al = new ArrayList();

        List<Student> li = new List<Student>()
        {
            new Student
            {
                Id=1,
                Name="Shubhanshu",
                Height=178.0f,
                AttendancePercentage=100.0f
            },
            new Student
            {
                Id=2,
                Name="Aditya",
                Height=179.0f,
                AttendancePercentage=100.0f
            },
            new Student
            {
                Id=3,
                Name="Aman",
                Height=176.0f,
                AttendancePercentage=90.0f
            },
            new Student
            {
                Id=4,
                Name="Ayush",
                Height=null,
                AttendancePercentage=85.0f
            },
            new Student
            {
                Id=5,
                Name="Amit",
                Height=174f,
                AttendancePercentage=95.0f
            }
        };

        foreach (var i in li)
        {
            if (i.Height == null)
            {
                Console.WriteLine("Height Not Available for " + i.Name);
            }
            else
            {
                Console.WriteLine($"Height {i.Height} is present for {i.Name}");
            }

            if (i.AttendancePercentage > 75.5f)
            {
                Console.WriteLine("Name of the Student Who got more than 75.5 is " + i.Name);
            }
        }

        foreach (var student in li)
        {
            string name = student.Name;

            for (int j = 0; j < name.Length; j += 2)
            {
                Console.WriteLine(name[j]);
            }
        }
    }
}
