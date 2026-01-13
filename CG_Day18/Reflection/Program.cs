using System.Reflection;
using System;
using System.Collections.Concurrent;



// ======================= BELOW IS THE EXAMPLE OF GEETTING TYPE  USING NAMESPACES===============================

// // namespace apple
// // {

// //     namespace orange
// //     {

// // class Employee
// // {

// //     public void disp()
// //     {
// //         System.Console.WriteLine("this is from apple class");
// //     }

// // public string name{get;set;}

// // public void show()
// //     {
// //         Console.WriteLine("this is Employee class");
// //     }

// //     public static void Main(string[] args)
// //     {

// //         Employee obj=new Employee();
// //         Type type = Type.GetType("apple.orange.Employee"); 
// //         Console.WriteLine(type);
// //     }

// // }}}

// =============================ACCESSING THE CURRENT RUNNING ASSEMBLY==============================

// Assembly assembly = Assembly.GetExecutingAssembly();
//  Assembly.Load("Reflection");// this is pass the name of the assembly
// Other commonly used methods include:
// Assembly.LoadFrom("MyPlugin.dll"); // this is use to pass the file location 

// Console.WriteLine(assembly);

// // ==========================//==============================//===========================//====================================


// class Employee
// {   
//     public string name { get; set; }
//     public string employeeName;
//     public string employeeWork;

//     public void show()
//     {
//         Console.WriteLine("This is Employee class");
//     }

    //  public Employee(string employeeName, string employeeWork) //created constructor with two parameter
    // {
//         this.employeeName = employeeName;
//         this.employeeWork = employeeWork;
//     }
    // public static void Main(string[] args)
    // {
//         Employee obj = new Employee();

// // =========================//================= Below is the example of Type ==========//=====================================//==========================
//         

//         // Type type = typeof(Employee); //(Compile time) this is used when we have multiple classes and have multiple namespaces
//         // Type type = obj.GetType();// (Runtime) this will help in checking the type of object 
//         // Type type = Type.GetType("MyApp.Models.Employee"); //in this type we needd to pass the namespace followed by class name
//         // Console.WriteLine(type);

// // ========================//=========================== Below is the  example of MethodInfo =======//===================================//=======================
//         

//         // Type type = obj.GetType();// (Runtime) this will help in checking the type of object 
//         // MethodInfo method = type.GetMethod("show"); // here are passing the name of the method present in the class 
//         // method.Invoke(obj, null); // passing the "object of the class" and passing "null as we do not have any parameter" to pass

// // =======================//======================== Below is the example of PropertyInfo ========//==================================//=============================
//         

//         // Type type = obj.GetType();// (Runtime) this will help in checking the type of object 
//         // PropertyInfo prop = type.GetProperty("name");
//         // prop.SetValue(obj, "John");
//         // Console.WriteLine(obj.name);

// // =======================//==================== Below is the example of FieldInfo ======//==================================//=============================
//         

//         // Type type = obj.GetType();// (Runtime) this will help in checking the type of object 
//         // FieldInfo field = type.GetField("employeeName", BindingFlags.NonPublic | BindingFlags.Instance);
//         // field.SetValue(obj, "Litchi");
//         // Console.WriteLine(field.GetValue(obj));

// //========================//=================== Below is the example of ConstructorInfo ==========//==================================//=============================== 
//         

//         // Type type =obj.GetType();

//         // This is used when we are "not passing" any parameter in the constructor....

//         // ConstructorInfo ctor = type.GetConstructor(Type.EmptyTypes);
//         // object obj = ctor.Invoke(null);

// // ---------------------------------//----------------------//-------------------------------//---------------------------------
//         // This is used when we are "passing" any parameter in the constructor....

//          Type type = typeof(Employee);
//          ConstructorInfo ctor = type.GetConstructor(new Type[] { typeof(string), typeof(string) });
//          object CTRobj = ctor.Invoke(new object[] { "apple", "Shubhanshu" });

         

// //========================//=============================//==================================//=============================== 

//     }
// }



// using System;
// using System.Reflection;
// namespace apple
// {
    
// class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     public void Work()
//     {
//         Console.WriteLine("Employee working");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Type type = typeof(Employee);

//         Console.WriteLine("Class Name: " + type.Name);
//         Console.WriteLine("Namespace: " + type.Namespace);

//         Console.WriteLine("Properties:");
//         foreach (PropertyInfo prop in type.GetProperties())
//         {
//             Console.WriteLine($"{prop.Name} - {prop.PropertyType}");
//         }

//         Console.WriteLine("Methods:");
//         foreach (MethodInfo method in type.GetMethods())
//         {
//             Console.WriteLine(method.Name);
//         }
//     }
// }

// }


// ========================//=======================//==========================//============================//===================



// ========================//=======================//==========================//============================//===================