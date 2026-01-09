using System;
using System.Collections.Generic;

public delegate bool IsEligibleforScholarship(Student student);

public class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public char SportsGrade { get; set; }

    public static string GetEligibleStudents(List<Student> studentList)
    {
        string studentEligible = "";
        IsEligibleforScholarship eligibleForScholarship = Program.ScholarshipEligibility;

        foreach (var s in studentList)
        {
            if (eligibleForScholarship(s))
            {
                studentEligible += s.Name + ", ";
            }
        }

        if (studentEligible.Length > 2)
        {
            studentEligible=studentEligible.Substring(0, studentEligible.Length-2);
        }

        return studentEligible;
    }
}

class Program
{
    public static bool ScholarshipEligibility(Student std)
    {
        return std.Marks > 80 && std.SportsGrade == 'A';
    }

    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        Student obj1 = new Student { RollNo = 1, Name = "Raj", Marks = 75, SportsGrade = 'A' };
        Student obj2 = new Student { RollNo = 2, Name = "Rahul", Marks = 82, SportsGrade = 'A' };
        Student obj3 = new Student { RollNo = 3, Name = "Kiran", Marks = 89, SportsGrade = 'B' };
        Student obj4 = new Student { RollNo = 4, Name = "Sunil", Marks = 86, SportsGrade = 'A' };

        students.Add(obj1);
        students.Add(obj2);
        students.Add(obj3);
        students.Add(obj4);

        string result = Student.GetEligibleStudents(students);
        Console.WriteLine("Eligible Students are:");
        Console.WriteLine(result);
    }
}
