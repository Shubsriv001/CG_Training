// using System;
// using BikeStore;
// class Program
// {
//     public static void Main(string[] args)
//     {

//         // All class Objects are created here...

//         Customers customers_obj = new Customers();
//         Products products_obj =new Products();

//         // ---------------------------------------

//         Console.WriteLine();
//         Console.WriteLine("....Welcome to Our BikStore....");
//         Console.WriteLine();

//         bool run = true;

//         while (run)
//         {
//             Console.WriteLine("1. Customer\n2. Staff\n0. Exit");

//             Console.WriteLine("....Plesse Enter Your Selection....");
//             int choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {

//                 case 1:

//                     Console.WriteLine("....You are Inside Customer Option....");
//                     Console.WriteLine();
//                     Console.WriteLine("1. Register\n2. Login\n3. Exit");
//                     int case1_choice = Convert.ToInt32(Console.ReadLine());

//                     switch (case1_choice)
//                     {
//                         case 1:
//                             Console.WriteLine("You are inside Customer -> Register");
//                             customers_obj.AddCustomer();
//                             Console.WriteLine("You are inside Customer -> Register -> Product List");
//                             products_obj.Customer_show_Product();
//                             break;

//                         case 2:
//                         up:
//                             Console.WriteLine("You are inside Customer -> Login");
//                             Console.WriteLine("Enter the Customer Id if You have Registered: ");
//                             int cust_id = Convert.ToInt32(Console.ReadLine());
//                             while (true)
//                             {
//                                 if (cust_id > 0)
//                                 {
//                                     break;
//                                 }
//                                 else
//                                 {
//                                     Console.WriteLine("Please Enter the valid Customer ID greater than 0");
//                                 }
//                             }
//                             if (cust_id > 0)
//                             {
//                                 Console.WriteLine("Looking inside List for the given customer id");
//                                 //Look in the list if present (LOGIC NEED TO ADD)...
//                             }
//                             else
//                             {
//                                 bool run1 = true;
//                                 while (run1)
//                                 {
//                                     Console.WriteLine("1. Register\n2. Search Again\n3. Exit");
//                                     Console.WriteLine("Please Choose from the option Given: ");
//                                     int innerchoice = Convert.ToInt32(Console.ReadLine());

//                                     switch (innerchoice)
//                                     {
//                                         case 1:
//                                             customers_obj.AddCustomer();
//                                             break;

//                                         case 2:
//                                             goto up;// this will help to move to the main switch case 1...

//                                             break;

//                                         case 3:
//                                             Console.WriteLine("Your are Out from the selection process...");
//                                             run1 = false;
//                                             break;

//                                     }

//                                 }
//                             }

//                             break;

//                         case 3:
//                             Console.WriteLine("You are Out from the selection Process...");
//                             return; // this is to stop the while loop...

//                         default:
//                             {
//                                 Console.WriteLine("Invalid Selection Please choose from the option given");
//                             }
//                             break;

//                     }

//                     break;


//                 case 2:
//                     // this block for Staff
//                     break;

//                 case 0:
//                     Console.WriteLine("You are Exit from the Selection Process.");
//                     run = false;
//                     break;

//                 default:
//                     Console.WriteLine("Invalid Choice");
//                     break;
//             }


//         }
//     }
// }


// -------------------------//---------------------//---------------------//---------------------//-----------------------
// WAP 1 -100 =/2 and /3 another list !/any another list print all
// using System;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         List<int> listTh = new List<int>();
//         List<int> listTw = new List<int>();
//         List<int> ListNo = new List<int>();
//         for (int i = 1; i <= 100; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 listTw.Add(i);
//             }
//             else if (i % 3 == 0)
//             {
//                 listTh.Add(i);
//             }
//             else if (i % 2 != 0 && i % 3 != 0)
//             {
//                 ListNo.Add(i);
//             }
//         }

//         Console.WriteLine("Divided by 2: ");
//         foreach (var i in listTw)
//         {
//             Console.Write(i + ", ");

//         }

//         Console.WriteLine();
//         Console.WriteLine("Divided by 3: ");
//         foreach (var i in listTh)
//         {
//             Console.Write(i + ", ");
//         }
//         Console.WriteLine();

//         Console.WriteLine("Divided by none: ");
//         foreach (var i in ListNo)
//         {
//             Console.Write(i + ", ");
//         }
//     }
// }

// ---------------------------------------- Interface -----------------------//---------------------------------
// car  gear interface mari car 


// using System;
// interface IGear
// {
//  void Gear1Test();   
//  void Gear2Test();   
//  void Gear3Test();   
//  void Gear4Test();   
//  void Gear5Test();   
//  void ReverseGearTest();   
// }

// class Mari : IGear
// {
//     void IGear.Gear1Test()
//     {
//        Console.WriteLine("This is gear 1 test");
//     }
//     void IGear.Gear2Test()
//     {
//        Console.WriteLine("This is gear 2 test");
//     }
//     void IGear.Gear3Test()
//     {
//        Console.WriteLine("This is gear 3 test");
//     }
//     void IGear.Gear4Test()
//     {
//        Console.WriteLine("This is gear 4 test");
//     }
//     void IGear.Gear5Test()
//     {
//        Console.WriteLine("This is gear 5 test");
//     }
//     void IGear.ReverseGearTest()
//     {
//        Console.WriteLine("This is Reverse gear test");
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Mari obj=new Mari();
//         IGear gear = obj;
//         gear.Gear1Test();
//         gear.Gear2Test();
//         gear.Gear3Test();
//         gear.Gear4Test();
//         gear.Gear5Test();
//         gear.ReverseGearTest();
        

        
        
//     }
// }

// -------------------------------Abstract---------------------
// using System;

// abstract class Mari
// {
//     public abstract void Gear1Test(); //(Mandatory)
//     public abstract void Gear2Test();//(Mandatory)

//     public virtual void Camera() //(non- Mandatory)
//     {
//         Console.WriteLine("this is camera method");
//     }

//     public virtual void Airbag() //(non- Mandatory)
//     {
//         Console.WriteLine("this is Airbag method");
//     }
// }

// class Car : Mari
// {
//     public override void Gear1Test()
//     {
//         Console.WriteLine("this is gear 1");
//     }

//     public override void Gear2Test()
//     {
//         Console.WriteLine("this is gear 2");
//     }

//     public override void Camera()
//     {
//         Console.WriteLine("this is overridden camera method");
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Car car = new Car();
//         car.Gear1Test();
//         car.Gear2Test();
//         car.Camera();
//         car.Airbag();
//     }
// }


// ---------------------------//--- Delegate ------------------------------


// using System;
// class Program
// {
//     public delegate void De_add (int a, int b);
//     public delegate void De_s (string s);
//     public static void Main(string[] args)
//     {

//         void Add(int a, int b)
//         {
//             int sum=a+b;
//             Console.WriteLine(sum);
//         }
//         void Sub(int a, int b)
//         {
//             int sub=a-b;
//             Console.WriteLine(sub);
//         }

//         void Show(string s)
//         {
//             Console.WriteLine("Length "+s.Length);
//         }
//         De_add de_add = new De_add(Add);
//         de_add+=Sub;

//         De_s de_s = new De_s(Show);
//         de_add(10,20);
//         de_s("Shubhanshu");
//     }
// }


// -------------------------------//-----------Extension method---------------//---------------------------------

// using System;

// class Program
// {
    
//     public static void Main(string[] args)
//     {
        
//     }
// }



// -------------------------Static method---------------------

