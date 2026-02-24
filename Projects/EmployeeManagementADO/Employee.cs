using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string cs = "Server=.\\SQLEXPRESS;Database=EmployeeManagement;Integrated Security=True";

        Console.Write("Enter Department: ");
        string dept = Console.ReadLine();  

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            // 1. Employees By Department
            Console.WriteLine("\nEmployees in Department:");
            SqlCommand cmd1 = new SqlCommand("sp_GetEmployeesByDepartment1", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@dept", dept);

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                Console.WriteLine(dr1[0] + " | " + dr1[1] + " | " + dr1[2] + " | " + dr1[3] + " | " + dr1[4]);
            }
            dr1.Close();


            // 2. Department Employee Count
            SqlCommand cmd2 = new SqlCommand("sp_getdepartmentemployeecount2", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@department", dept);

            SqlParameter output = new SqlParameter("@totalemployees", SqlDbType.Int);
            output.Direction = ParameterDirection.Output;
            cmd2.Parameters.Add(output);

            cmd2.ExecuteNonQuery();

            Console.WriteLine("\nTotal Employees in " + dept + ": " + output.Value);


            // 3. Employee Orders Report
            Console.WriteLine("\nEmployee Orders Report:");
            SqlCommand cmd3 = new SqlCommand("sp_getemployeeorders3", con);
            cmd3.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr2 = cmd3.ExecuteReader();
            while (dr2.Read())
            {
                Console.WriteLine(dr2[0] + " | " + dr2[1] + " | " + dr2[2] + " | " + dr2[3] + " | " + dr2[4]);
            }
            dr2.Close();


            // 4. Duplicate Employees
            Console.WriteLine("\nDuplicate Employees:");
            SqlCommand cmd4 = new SqlCommand("sp_getduplicateemployees3", con);
            cmd4.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr3 = cmd4.ExecuteReader();
            while (dr3.Read())
            {
                Console.WriteLine(dr3[0] + " | " + dr3[1] + " | " + dr3[3]);
            }
            dr3.Close();
        }

        Console.WriteLine("\nProgram Finished.");
        Console.ReadLine();
    }
}