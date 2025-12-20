using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Local_Method
{
    public void Calculator()
    {
         void add(int a, int b)
        {
            Console.WriteLine($"Sum of the number is {a+b}");
        }
        
         void sub(int a, int b)
        {
            Console.WriteLine($"Sub of the number is {a-b}");
        }

        add(10,2);
        sub(10,2);

    }


public static void Main(string[]args)
    {
    
    Local_Method l_obj=new Local_Method();

    l_obj.Calculator();
    }}
