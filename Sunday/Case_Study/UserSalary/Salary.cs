using System;

// program to read eno, ename, basic salary and calculate pf, hra, da, net salary and gross salary and print eno, ename, basic salary,
// gross salary and net salary*/
// pf 12% of basic salary.
// hra=20% of basic salary.
// da 15% of basic salary.
// gross salary=pf+hra+da+basic salary;
// net salary-gross salary pf;

class Salary
{
int employee_no;
string employee_name="";
double emplyoyee_basic_salary;



public void accept_data()
    {
        Console.WriteLine("Please Enter Your Employee Number:");
        employee_no=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please Enter Your Name:");
        employee_name=Console.ReadLine();
        Console.WriteLine("Please Enter Your Basic Salary:");
        emplyoyee_basic_salary=Convert.ToDouble(Console.ReadLine());

    }

    public  void display_data()
    {
        double pf=emplyoyee_basic_salary*12/100;
        double hra=emplyoyee_basic_salary*20/100;
        double da=emplyoyee_basic_salary*15/100;
        double employee_gross_salary=pf+hra+da+emplyoyee_basic_salary;
        double employee_net_salary=employee_gross_salary-pf;

        Console.WriteLine($"Employee Number: {employee_no}\nEmployee Name: {employee_name}\nEmployee Gross Salary: {employee_gross_salary}\nEmployee net salary: {employee_net_salary}");

    }
    public static void Main(string[] args)
    {
        Salary salary_obj=new Salary();
        salary_obj.accept_data();
        salary_obj.display_data();
    }
}