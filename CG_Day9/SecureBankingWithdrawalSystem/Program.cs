using System;
using BankingSystem;
class Program
{
    public static void Main(string[] args)
    {
        BankAccount bankAccount_obj=new BankAccount("12364",1005);

        bankAccount_obj.Withdraw();
    }
}