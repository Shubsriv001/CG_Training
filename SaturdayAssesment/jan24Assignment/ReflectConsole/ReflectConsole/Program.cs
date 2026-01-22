using System;
using System.Reflection;
using ReflectClass;

class Program
{
    static void Main()
    {
        Assembly asm = Assembly.LoadFrom(@"C:\Users\Shubhanshu Srivastav\Desktop\C_SHARP\ReflectClass\ReflectClass\bin\Debug\net8.0\ReflectClass.dll");

        foreach (Type type in asm.GetTypes())
        {
            Console.WriteLine(type.FullName);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            
            int i = 1;
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"Method {i}: {method.Name}");
                i++;
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
