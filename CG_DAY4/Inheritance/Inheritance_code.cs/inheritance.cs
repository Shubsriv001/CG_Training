// using System;

// class Inheritance
// {

//     class Person
//     {
//         string name="";
//         public Person(string Name)
//         {
//             this.name=Name;
//         }
//     }


//     class Student:Person
//     {
//         int roll_number;

//         public Student(int roll_number,string name):base(Name)
//         {
//             this.roll_number=roll_number;

//         }

//     }

//     public static void Main(string[]args)
//     {
//         Person person_obj=new Person("shubh");
//         Student student_obj=new Student(1,"shubh");



//     }
// }


// ---------------------------------------Interfaces---------------------------------------------



// using System;


// interface start
// {
    
//     void starting();
// }
// interface stop
// {
//     void stoping();
// }

// class Run:start,stop
// {
//     public void starting()
//     {
//         Console.WriteLine("Engine started");
//     }


//     public void stoping()
//     {
//         Console.WriteLine("Engine stoped");
        
//     }


//     public static void Main(string[]args)
//     {
//         Run run_obj=new Run();
//         run_obj.starting();
//         run_obj.stoping();
//     }
// }


// --------------------------------------------Method Overriding------------------------------------------------------------



// A derived class can modify the behavior of a base class method.
// Base Class
// class Animal
// {

//virtual keyword specify that this function can be override in the derived class.
//     public virtual void Sound()
//     {
//         Console.WriteLine("Animal makes sound");
//     }
// }
// Derived Class
// class Dog : Animal
// {
//     public override void Sound()
//     {
//         Console.WriteLine("Dog barks");
//     }
// }

// ------------------------------------------------------------------------------------------------
// To access the mathods of theparent classes into the derived class 

// class Dog : Animal
// {
//     public override void Sound()
//     {
//         base.Sound();
//         Console.WriteLine("Dog barks");
//     }
// }



// -------------------------------------// Sealed Classes and Methods \\-------------------------------------------


// Sealed Class
// Prevents inheritance.
// Sealed classes act as the "final version" of a class, ensuring that its logic cannot be altered or extended by any other class.
// sealed class Security { }

// Sealed Method
// Prevents overriding.
// A sealed method prevents further subclasses from changing the behavior of an inherited method.
// class Parent
// {
//     public virtual void Show() { }
// }

// class Child : Parent
// {
//     public sealed override void Show() { }


// --------------------------------------------------------------------------------

// sealed class prevent further inhertance not the sealed methods 

// class GrandChild : Child
// {
//     public override void Show()   // Compile-time error
//     {
//     }
// }

// -------------------------------------

// Composition vs Inheritance

// Inheritance (IS-A relationship):
// A class derives from another class.
// Example: Car IS-A Vehicle

// Composition (HAS-A relationship):
// A class contains another class as a field/property.
// Example: Car HAS-A Engine

// Key difference:

// Inheritance: reuse by extending a base class

// Composition: reuse by using objects of other classes

// Example of the Composition 


// class Engine
// {
//     public void Start()
//     {
//         Console.WriteLine("Engine started");
//     }
// }

// class Car
// {
//     Engine engine = new Engine();

//     public void Drive()
//     {
//         engine.Start();
//         Console.WriteLine("Car is driving");
//     }
// }


// ------------------------------Methode hidden---------------------------

// class Parent
// {
//     public void Show()
//     {
//         Console.WriteLine("Parent Show");
//     }
// }

// class Child : Parent
// {
//     public new void Show()
//     {
//         Console.WriteLine("Child Show");
//     }
// }


// Outputs
// Parent p = new Child();
// p.Show();      //(Parent Show)

// Child c = new Child();
// c.Show();      // (Child Show)



// ---------------------------------Work with the Static methods---------------------------------
// class A
// {
//     public static void Display()
//     {
//         Console.WriteLine("A Display");
//     }
// }

// class B : A
// {
//     public new static void Display()
//     {
//         Console.WriteLine("B Display");
//     }
// }


// ---------------------------------------------------------------------------------