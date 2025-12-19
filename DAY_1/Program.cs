using System;
using DAY_1;
class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator_obj=new Calculator();
        calculator_obj.add();
        calculator_obj.sub();
        calculator_obj.mul();
        calculator_obj.div();
        calculator_obj.Remainder();
    }
}