// using System;
// using System.Collections.Generic;

// public class Program
// {
//     public void RegisterCreator(CreatorStats record)
//     {
//         CreatorStats.EngagementBoard.Add(record);
//     }

//     public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
//     {
//         Dictionary<string, int> result = new Dictionary<string, int>();

//         foreach (var c in records)
//         {
//             int count = 0;
//             for (int i = 0; i < c.WeeklyLikes.Length; i++)
//                 if (c.WeeklyLikes[i] >= likeThreshold) count++;

//             if (count > 0)
//                 result.Add(c.CreatorName, count);
//         }
//         return result;
//     }

//     public double CalculateAverageLikes()
//     {
//         double sum = 0;
//         int count = 0;

//         foreach (var c in CreatorStats.EngagementBoard)
//             for (int i = 0; i < c.WeeklyLikes.Length; i++)
//             {
//                 sum += c.WeeklyLikes[i];
//                 count++;
//             }

//         return count == 0 ? 0 : sum / count;
//     }

//     public static void Main(string[] args)
//     {
//         Program p = new Program();
//         bool run = true;

//         while (run)
//         {
//             Console.WriteLine("\n1. Register Creator");
//             Console.WriteLine("2. Show Top Posts");
//             Console.WriteLine("3. Calculate Average Likes");
//             Console.WriteLine("4. Exit");
//             Console.WriteLine("Enter your choice:");
//             int choice = Convert.ToInt32(Console.ReadLine());

//             if (choice == 1)
//             {
//                 CreatorStats cs = new CreatorStats();
//                 Console.WriteLine("Enter Creator Name:");
//                 cs.CreatorName = Console.ReadLine();

//                 cs.WeeklyLikes = new double[4];
//                 Console.WriteLine("Enter weekly likes (Week 1 to 4):");
//                 for (int i = 0; i < 4; i++)
//                     cs.WeeklyLikes[i] = Convert.ToDouble(Console.ReadLine());

//                 p.RegisterCreator(cs);
//                 Console.WriteLine("Creator registered successfully");
//             }
//             else if (choice == 2)
//             {
//                 Console.WriteLine("Enter like threshold:");
//                 double t = Convert.ToDouble(Console.ReadLine());

//                 var res = p.GetTopPostCounts(CreatorStats.EngagementBoard, t);
//                 if (res.Count == 0)
//                     Console.WriteLine("No top-performing posts this week");
//                 else
//                     foreach (var r in res)
//                         Console.WriteLine(r.Key + " - " + r.Value);
//             }
//             else if (choice == 3)
//             {
//                 Console.WriteLine("Overall average weekly likes: " + p.CalculateAverageLikes());
//             }
//             else if (choice == 4)
//             {
//                 Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
//                 run = false;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid Input");
//             }
//         }
//     }
// }










// ------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;

public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public int Marks { get; set; }
}

public class StudentUtility
{
    public Dictionary<string, string> GetStudentDetails(string id)
    {
        Dictionary<string, string> result = new Dictionary<string, string>();

        foreach (var student in Program.studentDetails.Values)
        {
            if (student.Id == id)
            {
                result.Add(student.Id, student.Name + "_" + student.Course);
                return result;
            }
        }
        return result;
    }

    public Dictionary<string, Student> UpdateStudentMarks(string id, int marks)
    {
        Dictionary<string, Student> result = new Dictionary<string, Student>();

        foreach (var student in Program.studentDetails.Values)
        {
            if (student.Id == id)
            {
                student.Marks = marks;
                result.Add(student.Id, student);
                return result;
            }
        }
        return result;
    }
}

public class Program
{
    public static Dictionary<int, Student> studentDetails;

    public static void Main()
    {
        studentDetails = new Dictionary<int, Student>()
        {
            {1, new Student{Id="101", Name="Kushagra", Course="CSE", Marks=85}},
            {2, new Student{Id="102", Name="Amrit", Course="ML", Marks=78}}
        };

        StudentUtility std = new StudentUtility();
        bool run = true;

        while (run)
        {
            Console.WriteLine("1. Get Student Details");
            Console.WriteLine("2. Update Marks");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the student id");
                string id = Console.ReadLine();

                var result = std.GetStudentDetails(id);
                if (result.Count == 0)
                    Console.WriteLine("Student id not found");
                else
                    foreach (var item in result)
                        Console.WriteLine(item.Key + "   " + item.Value);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the student id");
                string id = Console.ReadLine();

                Console.WriteLine("Enter marks");
                int marks = Convert.ToInt32(Console.ReadLine());

                var result = std.UpdateStudentMarks(id, marks);
                if (result.Count == 0)
                    Console.WriteLine("Student id not found");
                else
                    Console.WriteLine("Marks updated successfully");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thank you");
                run = false;
            }
        }
    }
}
