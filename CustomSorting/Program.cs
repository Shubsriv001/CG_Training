using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public int Age;
    public int Marks;
}

class Program
{
    class student_data_Check:IComparer<Student>
    {
        public int Compare(Student std1, Student std2)
        {
            if (std1.Marks != std2.Marks)
            {
                
                return std2.Marks - std1.Marks;
            }
            else
            {
                
            return std1.Age - std2.Age;          
            }
        }
    }

    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Aditya", Age = 18, Marks = 100 },
            new Student { Name = "Pavan", Age = 22, Marks = 90 },
            new Student { Name = "Karan", Age = 21, Marks = 90 },
            new Student { Name = "Amit", Age = 20, Marks = 90},
            new Student { Name = "Arush", Age = 20, Marks = 100 },
            new Student { Name = "Aryan", Age = 20, Marks = 98 },
            new Student { Name = "Deepak", Age = 24, Marks = 75 },
        };

        students.Sort(new student_data_Check());

        foreach (var s in students)
            Console.WriteLine("Name = "+s.Name +" Age = "+"" + s.Age +" Marks = "+ " " + s.Marks);
    }
}

