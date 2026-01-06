// // this is the example of single casting delegates
// using System;



// // public delegate int MyDelegate(int a, int b); // example of delegate creation

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



// ==========================//==========================//=======================//======================

// using System;

// class Delegate
// {
//     static void Main()
//     {
//         Action<string> logActivity=message=>
//         Console.WriteLine("Log Entry: "+message);
//         logActivity("User Logged in at 10:30 AM");
//     }

// }




//============================//===========================//=========================
using System;
class Delegate
{
    static void Main()

    {
        // input type , input, return
        Func<decimal, decimal, decimal> calculateDiscount=(price, discount)=>price-(price*discount/100);
       Console.WriteLine(calculateDiscount(1000,10));
    }

}