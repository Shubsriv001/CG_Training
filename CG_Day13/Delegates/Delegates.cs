// // // this is the example of========== single casting delegates ===============
// using System;

// public delegate int MyDelegate(int a, int b); // example of delegate creation

// public delegate void PaymentDelegate(decimal amount); 
// // this is the creation of the delegates and we need to keep the retun type and the parameter same to use this delegates.....

// class PaymentService
// {

//         public void ProcessPayment(decimal amount)
//     {
//         Console.WriteLine("Payment of "+amount+ " processed Successfully");
//     }
// }

//     static class PaymentExtensions
//     {
//         public static bool IsValidPayment(this decimal amount)
//         {
//             return amount>0 && amount<=1_000_000; //we are using '_' here as a seperator
//         }
//     }

// class Delegate
// {

//     public static void Main(string[] args)
//     {
//        PaymentService service=new PaymentService();
//        PaymentDelegate payment=service.ProcessPayment; //delegate assignment

//     //    payment(5000); // this is for delegate
//     decimal amount=5000; // this is for extension class


//         if (amount.IsValidPayment())
//         {
//             payment(amount);
//         }
//         else
//         {
//             Console.WriteLine("Invalid Payment Amount...");
//         }

//     }
// }




// ================//========================//=====================//========================

// -------------------------------Multicast Delegates------------------------------------------


// using System;

// delegate void OrderDelegate(string orderId);


// class NotificationService
// {
//     public void  SendEmail(string id)
//     {
//         Console.WriteLine("Email Send for order "+ id);
//     }
//     public void SendSMS(string id)
//     {
//         Console.WriteLine("SMS Send for order "+ id);
//     }
// }


// class Delegate
// {
//     public static void Main(string[] args)
//     {
//         NotificationService service=new NotificationService();

//         OrderDelegate notify=null;
//         notify+=service.SendEmail;
//         notify+=service.SendSMS;

//         notify("ORD1001");
        
//     }
// }



// ==========================//============ Action Delegate==============//=======================//======================

// No return type mostly used for logging purpose but take the parameter input

// using System;

// class Delegate
// {
//   static void LogActivity(string message)
//     {
//         Console.WriteLine("Log Entry: " + message);
//     }

//     static void Main()
//     {
//         Action<string> logActivity = LogActivity;
//         logActivity("User Logged in at 10:30 AM");
//     }

// }




//============================//========= Func Delegates ==================//=========================
// have return type mostly used for single line function last aparemeter is the return type

// using System;
// class Delegate
// {
//     static void Main()

//     {
//         // input type , input, return
//         Func<decimal, decimal, decimal> calculateDiscount=(price, discount)=>price-(price*discount/100);
//        Console.WriteLine(calculateDiscount(1000,10));
//     }

// }


// --------------------------------------------------////--------------------------------------------------------------


// using System;

// class Delegate
// {
//     static decimal CalculateDiscount(decimal price, decimal discount)
//     {
//         return price - (price * discount / 100);
//     }

//     static void Main()
//     {
//         Func<decimal, decimal, decimal> calculateDiscount = CalculateDiscount;
//         Console.WriteLine(calculateDiscount(1000, 10));
//     }
// }



//==============================//==== Predicate Delegate ====================//=================

//Return the boolean use for validation and filtering , only accept one parameter.

// using System;
// class Delegate
// {
//     static void Main()

//     {
//         // here it take the int type parameter...

//         Predicate<int> IsEligible=age=>age>=18;
//         Console.WriteLine(IsEligible(20));        
//     }

// }

// ----------------------------------------------------/////--------------------------------------------------

// using System;

// class Delegate
// {
//     static bool IsEligible(int age)
//     {
//         return age >= 18;
//     }

//     static void Main()
//     {
//         Predicate<int> checkEligibility = IsEligible;
//         Console.WriteLine(checkEligibility(20));
//     }
// }




//=============================//====================//===================//===============

//============================== Anonymous Delegate =======================

// these are one time use 
// using System;

// delegate void ErrorDelegate(string message);
// class Delegate
// {
//     static void Main()

//     {
//             // ErrorDelegate errorHandler= delegate(string msg)
//             // {
//             //     Console.WriteLine("Error: "+msg);
//             // };
//             // errorHandler("File not found");

//            Comparison<int> sortDescending =(a,b)=> b.CompareTo(a);
//            Console.WriteLine(sortDescending(5,10)); //1 as a<
//            Console.WriteLine(sortDescending(5,5)); //0 a==b
//            Console.WriteLine(sortDescending(10,5)); // -1 a>b
           
//     }

// }

// ===========//=======================//== --EVENTS-- =================//===================


using System;

// Step 1: Create a delegate

public delegate void Notify();

// Step 2: Create a class with an event using the delegate

class Door
{
    public static event Notify DoorOpened;

    public void Open()
    {
        Console.WriteLine("Door is opened");
        DoorOpened?.Invoke();   // fire event
    }
}

class Program
{
    static void OnDoorOpened()
    {
        Console.WriteLine("Event handled using delegate");
    }

    static void guard()
    {
        Console.WriteLine("Guard are going to save you");
    }
    static void Main()
    {
        // Subscribe static event correctly
        Door.DoorOpened += OnDoorOpened;
        Door.DoorOpened += guard;
        Door door = new Door();
        door.Open();
    }
}

// ------------------------------------------------------------
// =================================================================

// using System;

// public delegate int mydel(int a , int b);
// class Delegateclass
// {
//     public int Add(int a,int b)
//     {
//         int sum=a+b;
//         return sum;
//     }
// }

// class Program
// {
//     public static void Main()
//     {
//         // this is the object of class 
//         Delegateclass obj =new Delegateclass();

//         // this is the object creation of delegate
//         mydel del=new mydel(obj.Add);
//         // del+=obj.Add;
//        Console.WriteLine(del.Invoke(1,2));

//     }
// }

// ------------------------------------------------------------------
// using System;

// delegate void NotifyDelegate();         
// class Practice
// {
//     public void EmergencyAlert()
//     {
//         System.Console.WriteLine("Bhagason re aag lagal haw...");
//     }

//     public void callPolice()
//     {
//         System.Console.WriteLine("Police ke Kauno phone lagawa jaldi");
//     }
    
// }

// class program
// {
//     public static void Main()
//     {
//      Practice practice=new Practice();
//      NotifyDelegate notifyDelegate=new NotifyDelegate(practice.EmergencyAlert);
//      notifyDelegate+=practice.callPolice;
//      notifyDelegate();   
//     }
// }

// ----------------------------------------------------------------------------