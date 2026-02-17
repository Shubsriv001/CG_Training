using System;
using Domain;
using Services;
using Exceptions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagementService service = new ManagementService();

            while (true)
            {
                Console.WriteLine("1. Display");
                Console.WriteLine("2. Add");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Remove");
                Console.WriteLine("5. Exit");

                // TODO: Read user choice
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // TODO: Display data
                        try
                        {
                            var all = service.GetAll();
                            foreach (var entity in all)
                            {
                                Console.WriteLine(entity.ToString());
                            }
                        }
                        catch (CustomBaseException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        // TODO: Add entity
                        try
                        {
                            Console.Write("Enter Key: ");
                            int key = Convert.ToInt32(Console.ReadLine());

                            SampleEntity entity = new SampleEntity();

                            Console.Write("Enter Id: ");
                            entity.Id = Console.ReadLine();

                            Console.Write("Enter Name: ");
                            entity.Name = Console.ReadLine();

                            service.AddEntity(key, entity);
                        }
                        catch (CustomBaseException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 3:
                        // TODO: Update entity
                        try
                        {
                            Console.Write("Enter Key: ");
                            int key = Convert.ToInt32(Console.ReadLine());

                            service.UpdateEntity(key);
                        }
                        catch (CustomBaseException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 4:
                        // TODO: Remove entity
                        try
                        {
                            Console.Write("Enter Key: ");
                            int key = Convert.ToInt32(Console.ReadLine());

                            service.RemoveEntity(key);
                        }
                        catch (CustomBaseException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 5:
                        Console.WriteLine("Thank You");
                        return;

                    default:
                        // TODO: Handle invalid choice
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
