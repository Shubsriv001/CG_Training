using System;

// program to read student num,name,mark of six subject in property and 
// calculate total and average and print result and division */

class Student
{
        int student_roll_no;
        string student_name=string.Empty;
        double []arr=new double[6];
        double avg_mark;
        double total_marks;

public void accept_student_data()
    {
        Console.WriteLine("Please Enter Your Roll Number:");
        student_roll_no=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter Your Name:");
        student_name=Console.ReadLine();
        Console.WriteLine("Please Enter Your Six Subject Marks:");

        for(int i = 0; i < arr.Length; i++)
        {
            double mark=Convert.ToDouble(Console.ReadLine());
            arr[i]=mark;
        }
    }

    public void calculate_result()
    {
        
        foreach(double i in arr){
            total_marks+=i;
        }
        avg_mark=total_marks/6;
    }

    public void display_result()
    {

        Console.WriteLine($"Your total Marks is {total_marks} and the average mark of the student {avg_mark}");
    }




    public static void Main(string[] agrs)
    {
        Student student_obj =new Student();
        student_obj.accept_student_data();
        student_obj.calculate_result();
        student_obj.display_result(); 
    }
}