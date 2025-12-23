using System;

abstract class InsurancePolicy{

string 
private Dictionary<int, string> user_data = new Dictionary<int, string>();    // string user_name="";
    // int user_policy_number;

    // string []arr=new string[5];
    // public void accept_data()
    // {

    //     Console.WriteLine("Please Enter Your Name to Authenticate");
    //     user_name=Console.ReadLine();

    //         if (user_name=="")
    //         {
    //             Console.WriteLine("Plaese Enter Your Authenticated Name to move forward...");
    //         }
    //         else
    //         {
    //             arr.Append(user_name);
    //             Console.WriteLine("User Authenticated Successfully");
    //         }


    //     }



    //     public void show()
    // {
    //     Console.WriteLine($"Name of the use is {user_name}");
    // }

    //     public static void Main(string[] args)
    // {
    //     Insurance obj=new Insurance();
    //     obj.accept_data();
    //     obj.show();
        
    // }


      public string this[int index]
    {
        get { return user_data[index]; }
        set { user_data[index] = value; }
    }

    public string this[string name]
    {
        get
        {
            return user_data.FirstOrDefault(e => e.Value == name).Value;
        }
    }

        public void show_policy()
    {
        Console.WriteLine("User Authenticated Successfully");


    }




    class InsurancePolicy
    {
        int insurance_polycy_number;

    }

public static void Main(string[] args)
    {
        Insurance insurance_obj=new Insurance();
        insurance_obj[0]="Amit";
        insurance_obj[1]="Ayush";
        insurance_obj[2]="Rahul";
    insurance_obj.show_policy();
Console.WriteLine(insurance_obj[0]);

    }}
