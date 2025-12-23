// using System;
// class Bank
// {
//     double balance;
//     double acc_no;

//     public Bank(double balance, double acc_no)
//     {
//         this.balance = balance;
//         this.acc_no = acc_no;
//         Console.WriteLine($"Bank Constructor: id = {balance}, user = {acc_no}");
//     }
// }


// // Note:
// // We can not inherit the constructor of the parent class, only we access it using base keyword
// // class Fix_Deposit : Bank
// // {
// //     int time_period;
// //     double fd_Amt;
// //     double rate_Of_interest;

//     // Child class constructor
//     // We can access the counstructor of the parent class using base
    // public Fix_Deposit(double balance, double acc_no) : base(balance,acc_no)
//     // {
//     //     Console.WriteLine("Fix_Deposit Constructor called");
//     // }
// // }

// // Static Constructor is only createdd for the static data members and it call only once througout the program

// class Program
// {
//     public static void Main(string[] args)
//     {
//         // Fix_Deposit fixDepositObj = new Fix_Deposit(1, "Shubhanshu");
//         Bank bank_obj=new Bank(10,10);
        
//    
// }
