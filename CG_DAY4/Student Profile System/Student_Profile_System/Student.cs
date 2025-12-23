// using System;

// class Student
// {
//     private string name;
//     private int age;
//     private double marks;
//     private string password;

//     public int registration_number { get; private set; }
//     public int admission_year { get; init; }

//     public Student(int regNo)
//     {
//         registration_number = regNo;
//     }

//     // Expression-bodied property
//     public double Student_Percent => marks;

//     // Auto-implemented property
//     public int Student_ID { get; set; }

//     public string Password
//     {
//         set
//         {
//             if (value.Length >= 6)
//                 password = value;
//             else
//                 Console.WriteLine("Please enter minimum 6 character password");
//         }
//     }

//     public string name_property
//     {
//         get { return name; }
//         set
//         {
//             if (!string.IsNullOrEmpty(value))
//                 name = value;
//         }
//     }

//     public int age_property
//     {
//         get { return age; }
//         set
//         {
//             if (value > 0)
//                 age = value;
//         }
//     }

//     public double marks_property
//     {
//         get { return marks; }
//         set
//         {
//             if (value > 0 && value <= 100)
//                 marks = value;
//         }
//     }

//     public string result
//     {
//         get { return marks >= 40 ? "Pass" : "Fail"; }
//     }

//     public static void Main(string[] args)
//     {
//         Student student_obj = new Student(101);

//         student_obj.name_property = "Subhanshu";
//         student_obj.age_property = 21;
//         student_obj.marks_property = 20;
//         student_obj.Password = "1k2356";

//         Console.WriteLine(
//             $"Student data: Name={student_obj.name_property}, Age={student_obj.age_property}, Marks={student_obj.marks_property}, Result={student_obj.result}"
//         );
//     }
// }
