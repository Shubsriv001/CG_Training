using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace BikeStore
{
    class Customers
    {
        public int customer_id;
        public string? first_name;
        public string? last_name;
        public string? phone;
        public string? email;
        public string? street;
        public string? city;
        public string? state;
        public int zip_code;

        public void AddCustomer()
        {
            Console.WriteLine("Enter Customer ID: ");
            while (true)
            {
                int c_id = Convert.ToInt32(Console.ReadLine());

                if (c_id > 0)
                {
                    customer_id = c_id;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid ID greater than 0:");
                }
            }

            Console.WriteLine("Enter Customer First Name: ");
            while (true)
            {
                first_name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(first_name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("First Name cannot be empty. Please enter a valid name:");
                }
            }

            Console.WriteLine("Enter Customer Last Name: ");
            while (true)
            {
                last_name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(last_name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Last Name cannot be empty. Please enter a valid name:");
                }
            }

            Console.WriteLine("Enter Customer Phone Number: ");
            while (true)
            {
                string phoneNumber = Console.ReadLine();
                if (phoneNumber.Length == 10)
                {
                    phone = phoneNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid phone number:");
                }
            }

            Console.WriteLine("Enter Customer Email Id: ");
            while (true)
            {
                email = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(email) && email.Contains("@"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid email address:");
                }
            }

            Console.WriteLine("Enter Customer Street: ");
            while (true)
            {
                street = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(street))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Street cannot be empty. Please enter a valid street:");
                }
            }

            Console.WriteLine("Enter Customer City: ");
            while (true)
            {
                city = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(city))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("City cannot be empty. Please enter a valid city:");
                }
            }

            Console.WriteLine("Enter Customer State: ");
            while (true)
            {
                state = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(state))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("State cannot be empty. Please enter a valid state:");
                }
            }

            Console.WriteLine("Enter Customer Zip Code: ");
            while (true)
            {
                zip_code = Convert.ToInt32(Console.ReadLine());
                if (zip_code > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Zip Code cannot be empty. Please enter a valid zip code:");
                }
            }
        }
    }


    class Staffs
    {
        public int staff_id;
        public string? first_name;
        public string? last_name;
        public int phone;
        public string? email;
        public bool active;
        public int store_id;
        public int manage_id;
    }

    class Orders
    {
        public string? Orders_id;
        public string? customer_id;
        public string? order_status;
        public DateTime order_date;
        public DateTime required_date;
        public DateTime shipped_date;
        public string? store_id;
        public int staff_id;
    }

    class Stores
    {
        public int store_id;
        public string? store_name;
        public int phone;
        public string? email;
        public string? street;
        public string? city;
        public string? state;
        public string? zip_code;
    }

    class Order_Item
    {
           public int Orders_id;
        public int item_id;
        public int product_id;
        public int quantity;
        public List<double> list_price;
        public double discount;
    }

    public class Products
    {
        public int product_id;
        public string? product_name;
        public int brand_id;
        public int category_id;
        public int model_year;

        public void staff_addProduct()
        {
                Console.WriteLine("Enter Product id: ");
            while (true)
            {
                product_id = Convert.ToInt32(Console.ReadLine());
                if (product_id > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid Product Id: ");
                }
            }
                Console.WriteLine("Enter the Product Name: ");
            while (true)
            {
                product_name = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(product_name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter the valid Product Name: ");
                }
            }

                Console.WriteLine("Enter the Brand ID: ");
            while (true)
            {
                brand_id = Convert.ToInt32(Console.ReadLine());
                if (brand_id > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter the valid Brand ID: ");
                }
            }

                Console.WriteLine("Enter the Categories ID: ");
            while (true)
            {
                category_id = Convert.ToInt32(Console.ReadLine());
                if (category_id > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter the valid Category ID: ");
                }
            }
                Console.WriteLine("Please Enter the Model Year");
            while (true)
            {
                model_year = Convert.ToInt16(Console.ReadLine());
                if (model_year > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter the valid Model year");
                }
            }
        }


        public void Customer_show_Product()
        {
            Console.WriteLine("This Function is to display the product to the customer");
        }


    }
}














