// using System;
// using System.Collections.Generic;

// class Student
// {
//     public string Name;
//     public int Age;
//     public int Marks;
// }

// class Program
// {
//     class student_data_Check:IComparer<Student>
//     {
//         public int Compare(Student std1, Student std2)
//         {
//             if (std1.Marks != std2.Marks)
//             {
                
//                 return std2.Marks - std1.Marks;
//             }
//             else
//             {
                
//             return std1.Age - std2.Age;          
//             }
//         }
//     }

//     static void Main()
//     {
//         List<Student> students = new List<Student>
//         {
//             new Student { Name = "Aditya", Age = 18, Marks = 100 },
//             new Student { Name = "Pavan", Age = 22, Marks = 90 },
//             new Student { Name = "Karan", Age = 21, Marks = 90 },
//             new Student { Name = "Amit", Age = 20, Marks = 90},
//             new Student { Name = "Arush", Age = 20, Marks = 100 },
//             new Student { Name = "Aryan", Age = 20, Marks = 98 },
//             new Student { Name = "Deepak", Age = 24, Marks = 75 },
//         };

//         students.Sort(new student_data_Check());

//         foreach (var s in students)
//             Console.WriteLine("Name = "+s.Name +" Age = "+"" + s.Age +" Marks = "+ " " + s.Marks);
//     }
// }


using System;
using System.Collections.Generic;

class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

    static void Main()
    {
        BikeUtility utility = new BikeUtility();
        int choice;

        do
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the model");
                    string model = Console.ReadLine();

                    Console.WriteLine("Enter the brand");
                    string brand = Console.ReadLine();

                    Console.WriteLine("Enter the price per day");
                    int price = int.Parse(Console.ReadLine());

                    utility.AddBikeDetails(model, brand, price);
                    Console.WriteLine("Bike details added successfully");
                    Console.WriteLine();
                    break;

                case 2:
                    SortedDictionary<string, List<Bike>> grouped = utility.GroupBikesByBrand();
                    foreach (var item in grouped)
                    {
                        Console.WriteLine(item.Key);
                        foreach (Bike b in item.Value)
                        {
                            Console.WriteLine(b.Model);
                        }
                        Console.WriteLine();
                    }
                    break;
            }

        } while (choice != 3);
    }
}

class Bike
{
    public string Model{get;set;}
    public string Brand{get;set;}
    public int PricePerDay{get;set;}
}

class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        Bike bike = new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        };

        int key = Program.bikeDetails.Count + 1;
        Program.bikeDetails.Add(key, bike);
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> result = new SortedDictionary<string, List<Bike>>();

        foreach (var item in Program.bikeDetails.Values)
        {
            if (!result.ContainsKey(item.Brand))
            {
                result[item.Brand] = new List<Bike>();
            }
            result[item.Brand].Add(item);
        }

        return result;
    }
}
